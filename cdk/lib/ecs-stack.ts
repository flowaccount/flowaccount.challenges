import * as dotenv from "dotenv"
import { Stack, Construct, StackProps, Tags, Fn } from '@aws-cdk/core'
dotenv.config()
import { environment } from '../environments/environment'
import { CfnLaunchTemplate, Peer, Port, SecurityGroup, SubnetType, Vpc, } from "@aws-cdk/aws-ec2"
import { Cluster, EcsOptimizedImage } from "@aws-cdk/aws-ecs"
import { AutoScalingGroup, CfnAutoScalingGroup } from '@aws-cdk/aws-autoscaling'
import { CfnInstanceProfile, Policy, PolicyStatement, Role, ServicePrincipal } from '@aws-cdk/aws-iam'
import { ApplicationTargetGroup } from '@aws-cdk/aws-elasticloadbalancingv2'

interface EcsStackProps extends StackProps {
    readonly vpc:Vpc
    readonly tg: ApplicationTargetGroup[]
}  
export class EcsStack extends Stack {
    public cluster : Cluster

    constructor(scope: Construct, id: string, props: EcsStackProps) {
    super(scope, id, props)


    const _cluster = new Cluster(this, 'ecs-cluster', {
        vpc: props.vpc,
        clusterName: environment.cluster.clusterName,
        containerInsights: true
      })
    this.cluster = _cluster

    const _policyStatement = new PolicyStatement()

    _policyStatement.addActions(`ec2:DescribeTags`)
    _policyStatement.addActions(`ecs:CreateCluster`)
    _policyStatement.addActions(`ecs:DeregisterContainerInstance`)
    _policyStatement.addActions(`ecs:DiscoverPollEndpoint`)
    _policyStatement.addActions(`ecs:Poll`)
    _policyStatement.addActions(`ecs:RegisterContainerInstance`)
    _policyStatement.addActions(`ecs:StartTelemetrySession`)
    _policyStatement.addActions(`ecs:UpdateContainerInstancesState`)
    _policyStatement.addActions(`ecs:Submit*`)
    _policyStatement.addActions(`ecr:GetAuthorizationToken`)
    _policyStatement.addActions(`ecr:BatchCheckLayerAvailability`)
    _policyStatement.addActions(`ecr:GetDownloadUrlForLayer`)
    _policyStatement.addActions(`ecr:BatchGetImage`)
    _policyStatement.addActions(`s3:*`)
    _policyStatement.addActions(`logs:CreateLogGroup`)
    _policyStatement.addActions(`logs:CreateLogStream`)
    _policyStatement.addActions(`logs:PutLogEvents`)
    _policyStatement.addActions(`logs:DescribeLogStreams`)
    _policyStatement.addResources(`*`)
    
    /////////////////////////////////new role & instance role

    const _policy = new Policy(this, `policy`, {
      policyName: environment.cluster.policyName,
      statements: [_policyStatement]
    })

    const _role = new Role(this, `role`, {
        roleName: environment.cluster.roleName,
        assumedBy: new ServicePrincipal(`ec2.amazonaws.com`)
      })
  
      _role.attachInlinePolicy(_policy)
    const _instanceProfile = new CfnInstanceProfile(this, `instance-profile`, {
        roles: [_role.roleName],
        instanceProfileName: environment.cluster.instanceProfileName
      })

    const _securityGroupLinux = new SecurityGroup(this, `linux-cluster-security-group`, {
        vpc: props.vpc,
        allowAllOutbound: true,
        securityGroupName: environment.cluster.securityGroupName
      })
      
      _securityGroupLinux.addIngressRule(Peer.anyIpv4(), Port.allTcp()) // Map all port for ecs dynamic random port to alb
           

          const _linuxUserData = `
          #!/bin/bash
          echo ECS_CLUSTER=${_cluster.clusterName} >> /etc/ecs/ecs.config
          sudo yum update -y
          sudo yum -y install python-pip
          sudo pip install s3cmd
          mkdir /home/ec2-user/config
          sudo s3cmd sync s3://app-production-config /home/ec2-user/config
          { sudo crontab -l; sudo echo "* * * * * sudo s3cmd sync s3://app-production-config /home/ec2-user/config"; } | sudo crontab -
          `

 /////////////////////////////////new autoscaling cpu2mem1
    
 const _linuxEcsCpu2Mem1LaunchTemplate = new CfnLaunchTemplate(this, `linux-cpu2mem1-launchtemplate`, {
    launchTemplateName: environment.cluster.ecsLaunchTemplate.name,
    launchTemplateData: {
      imageId: EcsOptimizedImage.amazonLinux2().getImage(this).imageId,
      instanceType:environment.cluster.ecsLaunchTemplate.instanceType,
      keyName: environment.cluster.ecsLaunchTemplate.keyName,
      securityGroupIds: [_securityGroupLinux.securityGroupId],
      iamInstanceProfile: { arn: _instanceProfile.attrArn },
      userData: Fn.base64(_linuxUserData)
    }
  })

  const _autoScalingGroupLinuxCpu2Mem1 = new CfnAutoScalingGroup(this, `linux-cpu2mem1-ecs-production-asg`, {
    minSize: `3`,
    maxSize: `8`,
    desiredCapacity: `8`,
    autoScalingGroupName: environment.cluster.autoScalingGroupName,
    vpcZoneIdentifier: props.vpc.selectSubnets({subnetType: SubnetType.PRIVATE}).subnetIds
  })
  
  _autoScalingGroupLinuxCpu2Mem1.addPropertyOverride("NewInstancesProtectedFromScaleIn", true)
  _autoScalingGroupLinuxCpu2Mem1.addPropertyOverride("LaunchConfigurationName", undefined)
  _autoScalingGroupLinuxCpu2Mem1.addPropertyOverride(`MixedInstancesPolicy`, {
      LaunchTemplate: {
        LaunchTemplateSpecification: {
          LaunchTemplateName: _linuxEcsCpu2Mem1LaunchTemplate.launchTemplateName,
          Version: "3"
        },
        Overrides: [
          {
            InstanceType: "t3.micro"
          },
          {
            InstanceType: "t3a.micro"
          }
        ]
      },
      InstancesDistribution: {
        OnDemandAllocationStrategy: "prioritized",
        OnDemandBaseCapacity: 3,
        OnDemandPercentageAboveBaseCapacity: 0,
        SpotAllocationStrategy: "capacity-optimized"
      }
  })
  _autoScalingGroupLinuxCpu2Mem1.addDependsOn(_linuxEcsCpu2Mem1LaunchTemplate)
  
    Tags.of(this).add("StackName", environment.stack.stackName)
  }
}