import { Stack, StackProps, Construct } from '@aws-cdk/core'
import { Role } from '@aws-cdk/aws-iam'
import { Cluster, TaskDefinition, Compatibility, NetworkMode, ContainerImage, Ec2Service, PlacementConstraint, LogDrivers, PlacementStrategy, Secret } from '@aws-cdk/aws-ecs'
import { ApplicationTargetGroup } from '@aws-cdk/aws-elasticloadbalancingv2'

interface APIStackProps extends StackProps {
    readonly cluster: Cluster
    readonly tg: ApplicationTargetGroup
}  

export class PouchAPIStack extends Stack {
  constructor(scope: Construct, id: string, props: APIStackProps) {
    super(scope, id, props)   

    const _cluster = props.cluster

    const _executionRole = Role.fromRoleArn(this, 'execution-role-arn',`arn:aws:iam::765141697745:role/ECSTaskExecutionRole`)

    const _ecrImage = `765141697745.dkr.ecr.ap-southeast-1.amazonaws.com/flowaccount/pouch-api`

    const _cpuBlue = 2048
    const _memoryBlue = 4024
    const _hostname = `pouchanagement.flowaccount.com`
    const _ecrImageTagBlue = `prod-15`
    const _blueInstanceTypeList = `t3.micro`
    const _minBlue = 1
    const _maxBlue = 1
    const _desireBlue = 1
    const _cpuScalingTrigger = 20

    /////////////////////////////////blue service

    const  _taskDefinitionBlue = new TaskDefinition(this, `pouch-api-blue-taskdef`, {
      compatibility: Compatibility.EC2,
      executionRole: _executionRole,
      taskRole: _executionRole,
      networkMode: NetworkMode.NAT,
      cpu: `${_cpuBlue}`,
      memoryMiB: `${_memoryBlue}`
    }) //windows container support only NAT

    const _containerBlue = _taskDefinitionBlue.addContainer(`pouch-api-blue-container`, {
      image: ContainerImage.fromRegistry(`${_ecrImage}:${_ecrImageTagBlue}`),
      memoryLimitMiB: _memoryBlue,
      cpu: _cpuBlue,
      hostname: _hostname
    }) //windows container not support memory reserved

    _containerBlue.addPortMappings({
      hostPort: 0, // 0 for dynamic random port on container provision
      containerPort: 80
    })

    const _serviceBlue = new Ec2Service(this, `pouch-api-blue-service`, {
      serviceName: `pouch-api-blue-prod-service`,
      cluster: _cluster,
      taskDefinition: _taskDefinitionBlue,
      assignPublicIp: false,
      desiredCount: _desireBlue
    })

    const _scalingBlue = _serviceBlue.autoScaleTaskCount({
      minCapacity: _minBlue,
      maxCapacity: _maxBlue
    })

    _scalingBlue.scaleOnCpuUtilization(`pouch-api-blue-cpu-auto-scale`, {
      targetUtilizationPercent: _cpuScalingTrigger
    })
    
    _serviceBlue.addPlacementStrategies(PlacementStrategy.spreadAcross(`attribute:ecs.availability-zone`))
    _serviceBlue.addPlacementConstraints(PlacementConstraint.memberOf(`attribute:ecs.os-type == linux and attribute:ecs.instance-type in [${_blueInstanceTypeList}]`))
 
    _serviceBlue.attachToApplicationTargetGroup(props.tg)
  }
}
