# FlowAccount Challenges (The Pouch Application)

### 1. Introduction
Pouch is an personal expenses tracking application with an intuitive UI showing all transactions as a list of card view.


## Aws-CDK

For the infrastructure we have the ready part for transaction that is working now.
What we would like you to do is create a new stack to deploy to the same cluster for a wallet service.
The hello world code for wallet service can be found here --> https://github.com/flowaccount/flowaccount.challenges/tree/main/cdk

## Useful commands

 * `yarn build`   compile typescript to js
 * `yarn watch`   watch for changes and compile
 * `yarn test`    perform the jest unit tests
 * `yarn cdk-fadev deploy [StackName]`      deploy this stack to fadev AWS account/region
 * `yarn cdk-fadev diff [StackName]`        compare deployed stack with current state
 * `yarn cdk-fadev synth [StackName]`       emits the synthesized CloudFormation template
