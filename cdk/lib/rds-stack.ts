import * as dotenv from "dotenv"
import { Stack, Construct, StackProps, Tags } from '@aws-cdk/core'
dotenv.config()
import { environment } from '../environments/environment'
import { DatabaseInstance, DatabaseInstanceEngine, LicenseModel, StorageType } from "@aws-cdk/aws-rds";
import { InstanceClass, InstanceSize, InstanceType, Vpc } from "@aws-cdk/aws-ec2";

interface RdsStackProps extends StackProps {
    readonly vpc: Vpc
}  
export class RdsStack extends Stack {
  constructor(scope: Construct, id: string, props: RdsStackProps ) {
    super(scope, id, props)

    new DatabaseInstance(this, "RdsInstance", {         
        vpc: props.vpc,      
        availabilityZone: environment.rds.multiAz ? undefined : environment.rds.availabilityZone,
        //if multi az not define it's default to zone a 
        multiAz: environment.rds.multiAz, 
        instanceClass: InstanceType.of(InstanceClass.M4, InstanceSize.LARGE),
        //minimum instance class for multi az was m4.large      
        instanceIdentifier: environment.rds.instanceIdentifier,      
        engine: DatabaseInstanceEngine.sqlServerEx({}),
        //minimum engine for multi az was standard edition (mssql)      
        engineVersion: environment.rds.engineVersion,      
        allowMajorVersionUpgrade: environment.rds.allowMajorVersionUpgrade ? true : false,
        //require true on upgrade major version      
        autoMinorVersionUpgrade: environment.rds.autoMinorVersionUpgrade ? true : false,      
        licenseModel: LicenseModel.LICENSE_INCLUDED,      
        storageType: StorageType.GP2,      
        allocatedStorage: environment.rds.dbSize,      
        masterUsername: environment.rds.username,      
        masterUserPassword: environment.rds.password,        
        //require on multi az == true      
        deletionProtection: environment.rds.deletionProtection ? true : false   
     });

    Tags.of(this).add("StackName", environment.stack.stackName)
  }
}

