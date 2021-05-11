#!/usr/bin/env node
import 'source-map-support/register'
import { App } from '@aws-cdk/core'
import { VpcStack } from '../lib/vpc-stack'
import { AlbStack } from '../lib/alb-stack'

import { environment } from '../environments/environment'
import { RdsStack } from '../lib/rds-stack'

const _app = new App()
const _vpc = new VpcStack(_app, 'VpcStack', environment.awsCredential)
new RdsStack(_app, 'RdsStack', { env: environment.awsCredential.env, vpc: _vpc.vpc })
new AlbStack(_app, 'AlbStack', { env: environment.awsCredential.env, vpc: _vpc.vpc })