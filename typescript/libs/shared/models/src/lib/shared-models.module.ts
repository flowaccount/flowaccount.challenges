import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TransactionModel } from './models/transactionModel';

@NgModule({
  imports: [CommonModule],
  exports: [TransactionModel]
})
export class SharedModelsModule {}
