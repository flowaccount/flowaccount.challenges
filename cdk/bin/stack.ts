#!/usr/bin/env node
import 'source-map-support/register'
import { App } from '@aws-cdk/core'
import { VpcStack } from '../lib/vpc-stack'
import { AlbStack } from '../lib/alb-stack'

import { environment } from '../environments/environment'

const _app = new App()
const _vpc = new VpcStack(_app, 'VpcStack', environment.awsCredential)
new AlbStack(_app, 'AlbStack', { env: environment.awsCredential.env, vpc: _vpc.vpc })