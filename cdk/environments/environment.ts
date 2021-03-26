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
        { 
            name: "database" 
        }
    ],
    rds: {
        username: "new",
        password: "password",
        availabilityZone: "availabilityZone",
        multiAz: true,
        instanceIdentifier: "instanceIdentifier",
        engineVersion: "",
        allowMajorVersionUpgrade: true,
        autoMinorVersionUpgrade: true,
        dbSize: 100,
        deletionProtection: true
    }
}