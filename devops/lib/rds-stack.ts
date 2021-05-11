import * as dotenv from "dotenv"
import { Stack, Construct, StackProps, Tags, Duration } from '@aws-cdk/core'
dotenv.config()
import { environment } from '../environments/environment'
import { Credentials, DatabaseInstance, LicenseModel, StorageType, SubnetGroup } from "@aws-cdk/aws-rds";
import { Subnet, SubnetType, Vpc } from "@aws-cdk/aws-ec2";
import { Secret } from "@aws-cdk/aws-secretsmanager"

interface RdsStackProps extends StackProps {
    readonly vpc: Vpc
}  
export class RdsStack extends Stack {
  constructor(scope: Construct, id: string, props: RdsStackProps ) {
    super(scope, id, props)

    const _ssm = new Secret(this, `${environment.rds.instanceIdentifier}-secrets`, {
      generateSecretString: {
        secretStringTemplate: JSON.stringify({ username: environment.rds.username }),
        generateStringKey: 'password',
      }
    })

    new DatabaseInstance(this, environment.rds.instanceIdentifier, {         
        vpc: props.vpc,   
        subnetGroup: new SubnetGroup(this, `${environment.rds.instanceIdentifier}-subnet-group`, {
          vpcSubnets: props.vpc.selectSubnets({subnetType: SubnetType.ISOLATED}),
          vpc: props.vpc,
          subnetGroupName: `${environment.rds.instanceIdentifier}-subnet-group`,
          description: `${environment.rds.instanceIdentifier}-subnet-group`
        }),    
        availabilityZone: props.vpc.availabilityZones[0],
        instanceType: environment.rds.instanceType,
        instanceIdentifier: environment.rds.instanceIdentifier,      
        engine: environment.rds.engine,    
        licenseModel: LicenseModel.LICENSE_INCLUDED,      
        storageType: StorageType.GP2,      
        allocatedStorage: environment.rds.dbSize,          
        deletionProtection: environment.rds.deletionProtection,
        credentials: Credentials.fromSecret(_ssm),
        backupRetention: Duration.days(0),
        deleteAutomatedBackups: true
     });

    Tags.of(this).add("StackName", environment.stack.stackName)
  }
}

