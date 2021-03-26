import * as dotenv from "dotenv"
import { Stack, Construct, StackProps, Tags } from '@aws-cdk/core'

dotenv.config()

import { environment } from '../environments/environment'
import { Peer, Port, Protocol, SecurityGroup, Vpc } from "@aws-cdk/aws-ec2"
import { ApplicationLoadBalancer, ApplicationProtocol, ApplicationTargetGroup, IpAddressType, ListenerAction, TargetType } from "@aws-cdk/aws-elasticloadbalancingv2"
import { Certificate, CertificateValidation } from "@aws-cdk/aws-certificatemanager"
import { CnameRecord, HostedZone } from "@aws-cdk/aws-route53"

interface AlbStackProps extends StackProps {
    readonly vpc: Vpc
}  

export class AlbStack extends Stack {

  readonly targetGroupList: ApplicationTargetGroup[] = [] 

  constructor(scope: Construct, id: string, props: AlbStackProps) {
    super(scope, id, props)

    //Alb Security Group
    const _sg = environment.alb.securityGroup
    const _securityGroup = new SecurityGroup(this, _sg.name, {
        vpc: props.vpc,
        allowAllOutbound: true,
        securityGroupName: _sg.name
    })

    _sg.inboudRule.forEach(ingressRule => {
        _securityGroup.addIngressRule(
            Peer.ipv4(ingressRule.ipRange), 
            ingressRule.protocol == Protocol.TCP ? 
            Port.tcp(ingressRule.port) : Port.udp(ingressRule.port)
        )
    })
  
    //Acm
    const _route53PublicHZ = HostedZone.fromHostedZoneAttributes(this, environment.route53.zoneName, environment.route53)

    const _publicCertification = new Certificate(this, environment.acm.name, {
        domainName: environment.acm.domainName,
        validation: CertificateValidation.fromDns(_route53PublicHZ)
    })

    //Alb
    const _alb = new ApplicationLoadBalancer(this, environment.alb.name, {
        vpc: props.vpc,
        internetFacing: true,
        loadBalancerName: environment.alb.name,
        ipAddressType: IpAddressType.IPV4,
        securityGroup: _securityGroup
    })

    //Route53 Recordset
    environment.route53.cnameAppList.forEach(cname => {
        new CnameRecord(this, `cname-${cname.app}`, {
            zone: _route53PublicHZ,
            recordName: cname.app,
            domainName: _alb.loadBalancerDnsName
        })
    })
  
    //Http Listener Rule Redirect 80 => 443 by default
    const _listenerHttp = _alb.addListener("http-listener", {
        port: 80,
        open: true
    })

    _listenerHttp.addAction("http-rule-default-tg", {
        action: ListenerAction.redirect({
            protocol: "HTTPS",
            port: "443"
        })
    })
  
    //Https Listener Rule
    const _listenerHttps = _alb.addListener("https-listener", {
        port: 443,
        open: true,
        certificates: [_publicCertification]
    })

    _listenerHttps.addAction("https-rule-default-tg", {
        action: ListenerAction.fixedResponse(404)
    })

    let _targetGroup: ApplicationTargetGroup
    environment.application.forEach(application => {

        _targetGroup = new ApplicationTargetGroup(this, `https-${application.targetgroup.name}`, {
          targetGroupName: application.targetgroup.name,
          targetType: TargetType.INSTANCE,
          protocol: ApplicationProtocol.HTTP,
          port: 80,
          vpc: props.vpc
        })
  
        _listenerHttps.addTargetGroups(`https-rule-${application.targetgroup.name}`, {
          conditions: application.albRuleCondition,
          targetGroups: [_targetGroup],
          priority: application.albRulePriority
        })
        
        this.targetGroupList.push(_targetGroup)
    })  

    Tags.of(this).add("StackName", environment.stack.stackName)
  }
}
