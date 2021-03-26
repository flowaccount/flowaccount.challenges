import { Stack, StackProps, Construct } from '@aws-cdk/core'
import { Role } from '@aws-cdk/aws-iam'
import { Cluster, TaskDefinition, Compatibility, NetworkMode, ContainerImage, Ec2Service, PlacementConstraint, PlacementStrategy, Scope } from '@aws-cdk/aws-ecs'
import { ApplicationTargetGroup } from '@aws-cdk/aws-elasticloadbalancingv2'


interface UIStackProps extends StackProps {
    readonly cluster: Cluster
    readonly tg: ApplicationTargetGroup
}  

export class PouchUIStack extends Stack {
  constructor(scope: Construct, id: string, props: UIStackProps) {
    super(scope, id, props)
 
    const _cluster = props.cluster

    const _executionRole = Role.fromRoleArn(this, 'execution-role-arn',`arn:aws:iam::765141697745:role/ECSTaskExecutionRole`)

    const _ecrImage = `765141697745.dkr.ecr.ap-southeast-1.amazonaws.com/flowaccount/my-ui`
    const _cpuBlue = 1024
    const _memoryBlue = 478
    const _hostname = `my.flowaccount.com`
    const _ecrImageTagBlue = `production-71`
    const _blueInstanceTypeList = `t3.micro`
    const _desireBlue = 1

    /////////////////////////////////blue service

    const  _taskDefinitionBlueNew = new TaskDefinition(this, `my-ui-blue-taskdef`, {
      compatibility: Compatibility.EC2,
      executionRole: _executionRole,
      taskRole: _executionRole,
      networkMode: NetworkMode.BRIDGE,
      cpu: `${_cpuBlue}`,
      memoryMiB: `${_memoryBlue}`,
      volumes: [
        {
          name: `pouch-ui-environment`,
          host: {
            sourcePath: `/home/ec2-user/config/pouch-ui/frontend`
          }
        },
        {
          name: `pouch-ui-server`,
          host: {
            sourcePath: `/home/ec2-user/config/pouch-ui/server`
          }
        },
      ]
    }) 

    const _containerBlueNew = _taskDefinitionBlueNew.addContainer(`pouch-ui-blue-container`, {
      image: ContainerImage.fromRegistry(`${_ecrImage}:${_ecrImageTagBlue}`),
      memoryLimitMiB: _memoryBlue,
      cpu: _cpuBlue,
      hostname: _hostname
    }) 

    _containerBlueNew.addPortMappings({
      hostPort: 0, // 0 for dynamic random port on container provision
      containerPort: 8081
    })

    _containerBlueNew.addMountPoints({
      containerPath: `/app/public/assets/environments`,
      sourceVolume: `pouch-ui-environment`,
      readOnly: false
    })

    _containerBlueNew.addMountPoints({
      containerPath: `/app/config`,
      sourceVolume: `pouch-ui-server`,
      readOnly: false
    })

    const _serviceBlue = new Ec2Service(this, `pouch-ui-blue-service`, {
      serviceName: `pouch-ui-blue-prod-service-stack`,
      cluster: _cluster,
      taskDefinition: _taskDefinitionBlueNew,
      assignPublicIp: false,
      desiredCount: _desireBlue
    })

    _serviceBlue.addPlacementStrategies(PlacementStrategy.spreadAcross(`attribute:ecs.availability-zone`))
    _serviceBlue.addPlacementConstraints(PlacementConstraint.memberOf(`attribute:ecs.os-type == linux and attribute:ecs.instance-type in [${_blueInstanceTypeList}]`))
 
    _serviceBlue.attachToApplicationTargetGroup(props.tg)

  }
}
