#!/usr/bin/env node
import 'source-map-support/register'
import { App } from '@aws-cdk/core'
import { VpcStack } from '../lib/vpc-stack'

import { environment } from '../environments/environment'

const _app = new App()
const _vpc = new VpcStack(_app, 'VpcStack', environment.awsCredential)
