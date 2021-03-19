import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TransactionListComponentComponent } from './transaction-list-component/transaction-list-component.component';
import { TransactionFormComponentComponent } from './transaction-form-component/transaction-form-component.component';




@NgModule({
  declarations: [TransactionListComponentComponent, TransactionFormComponentComponent],
  imports: [
    CommonModule
  ]
})
export class TransactionModule { }
