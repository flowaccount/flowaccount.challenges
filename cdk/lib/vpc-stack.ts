import * as dotenv from "dotenv"
import { DefaultInstanceTenancy, Subnet, Vpc } from '@aws-cdk/aws-ec2'
import { Stack, Construct, StackProps, Tags } from '@aws-cdk/core'

dotenv.config()

import { environment } from '../environments/environment'

export class VpcStack extends Stack {

  readonly vpc: Vpc

  readonly subnets: Subnet[]

  constructor(scope: Construct, id: string, props?: StackProps) {
    super(scope, id, props)

    //#region VPC & Subnets
    this.vpc = new Vpc(this, environment.vpc.name, {
      cidr: environment.vpc.cidr,
      defaultInstanceTenancy: DefaultInstanceTenancy.DEFAULT,
      enableDnsHostnames: true,
      enableDnsSupport: true,
      maxAzs: environment.vpc.maxAzs,
      subnetConfiguration: environment.vpc.subnetConfiguration
    })
    Tags.of(this.vpc).add("Name", environment.vpc.name)

    let _subnetCidrBlockCount = 0

    const _subnetPublicList = this.vpc.publicSubnets
    _subnetPublicList.forEach(_subnetPublicItem => {
      Tags.of(_subnetPublicItem).add("Name", `public-${_subnetPublicItem.availabilityZone}`)
      _subnetCidrBlockCount++
    })

    const _subnetPrivateList = this.vpc.privateSubnets
    _subnetPrivateList.forEach(_subnetPrivateItem => {
      Tags.of(_subnetPrivateItem).add("Name", `private-${_subnetPrivateItem.availabilityZone}`)
      _subnetCidrBlockCount++
    })

    let _subnetObject: Subnet

    environment.subnets.forEach(_subnet => {
      this.vpc.availabilityZones.forEach(_az => {

        _subnetObject = new Subnet(this, `${_subnet.name}-${_az}`, {
          vpcId: this.vpc.vpcId,
          cidrBlock: `${process.env.VPC_CIDR_PREFIX}.${_subnetCidrBlockCount}.0/${process.env.SUBNET_MASK}`,
          availabilityZone: _az
        })
        Tags.of(_subnetObject).add("Name", `${_subnet.name}-${_az}`)
        _subnetCidrBlockCount++
      })
    })

    //#endregion


    Tags.of(this).add("StackName", environment.stack.stackName)
  }
}
