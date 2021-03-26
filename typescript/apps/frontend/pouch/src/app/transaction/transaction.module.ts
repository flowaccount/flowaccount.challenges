import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TransactionListComponentComponent } from './transaction-list-component/transaction-list-component.component';
import { TransactionFormComponentComponent } from './transaction-form-component/transaction-form-component.component';
import { TransactionRoutingModule } from './transaction-routing.module';




@NgModule({
  declarations: [TransactionListComponentComponent, TransactionFormComponentComponent],
  imports: [
    CommonModule,
    TransactionRoutingModule
  ]
})
export class TransactionModule { }
