import * as dotenv from "dotenv"
import { SubnetType } from "@aws-cdk/aws-ec2"

dotenv.config()

export const environment = {
    awsCredential: { env: { account: process.env.AWS_ACCOUNT_ID, region: process.env.AWS_REGION } },
    stack: {
        stackName: "Challenges-Stack"
    },
    vpc: {
        name: "fa-challenges-vpc",
        cidr: `${process.env.VPC_CIDR_PREFIX as string}.0.0/16`,
        maxAzs: Number(process.env.MAX_AZS as string),
        subnetConfiguration: [
            {
                name: "public",
                subnetType: SubnetType.PUBLIC,
                cidrMask: Number(process.env.SUBNET_MASK as string)
            },
            {
                name: "private",
                subnetType: SubnetType.PRIVATE,
                cidrMask: Number(process.env.SUBNET_MASK as string)
            }
        ]
    },
    subnets: [
        { name: "database" }
    ],

    cluster: {
        clusterName: "pounch-cluster",
        policyName: "ecs-pouch-cluster-policy",
        roleName: "ecs-pouch-cluster-role",
        instanceProfileName: "ecs-pouch-instance-profile",
        securityGroupName: `production-linux-revise-cluster-sg`,
        ecsLaunchTemplate : {name : `linux-cpu2mem1-production`, instanceType: `t3.micro` , keyName : `flowsingapore`},
        autoScalingGroupName: `pouch-ecs-linux-cpu2mem1-asg`,
    }
}

 