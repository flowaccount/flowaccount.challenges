import * as dotenv from "dotenv"
import { Protocol, SubnetType } from "@aws-cdk/aws-ec2"
import { ListenerCondition } from "@aws-cdk/aws-elasticloadbalancingv2"

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
    route53: {
        zoneName: `${process.env.DOMAIN}`,
        hostedZoneId: "Z1YG5PTYO483CG",
        cnameAppList: [
            { app: "pounch" }
        ]
    },
    acm: {
        name: "wildcard-flowaccount-dev",
        domainName: `*.${process.env.DOMAIN}`
    },
    alb: {
        name: "pounch-alb",
        securityGroup: { 
            name: "pounch-alb-sg",
            inboudRule: [
                { ipRange: "0.0.0.0/0", protocol: Protocol.TCP, port: 80 },
                { ipRange: "0.0.0.0/0", protocol: Protocol.TCP, port: 443 }
            ]

        }
    },
    application: [
        {
            albRuleCondition: [
                ListenerCondition.hostHeaders([`pounch.${process.env.DOMAIN}`])
            ],
            albRulePriority: 2,
            targetgroup: {
                name: "frontend-pounch-tg"
            }
        },
        {
            albRuleCondition: [
                ListenerCondition.hostHeaders([`pounch.${process.env.DOMAIN}`]),
                ListenerCondition.pathPatterns(['/api'])
            ],
            albRulePriority: 1,
            targetgroup: {
                name: "api-pounch-tg"
            }
        }
    ]
}