import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TransactionListComponentComponent } from './transaction-list-component/transaction-list-component.component';
import { TransactionFormComponentComponent } from './transaction-form-component/transaction-form-component.component';
import { TransactionRoutingModule } from './transaction-routing.module';
import { TransactionApiService } from './transaction-api-service.service';
import { NgxDatatableModule } from '@swimlane/ngx-datatable'
import { HttpClientModule, HttpClientXsrfModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';



@NgModule({
  declarations: [TransactionListComponentComponent, TransactionFormComponentComponent],
  imports: [
    CommonModule,
    TransactionRoutingModule,
    NgxDatatableModule,
    HttpClientModule,
    HttpClientXsrfModule,
  ],
  providers:[
    TransactionApiService,
    HttpClientModule,

  ]
})
export class TransactionModule { }
