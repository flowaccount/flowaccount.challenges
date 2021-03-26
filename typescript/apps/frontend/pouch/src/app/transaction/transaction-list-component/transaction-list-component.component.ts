import { Component, OnInit } from '@angular/core';
import { TransactionApiService } from '../transaction-api-service.service';
import { TransactionModel } from '@typescript/shared/models'

@Component({
  selector: 'typescript-transaction-list-component',
  templateUrl: './transaction-list-component.component.html',
  styleUrls: ['./transaction-list-component.component.scss']
})
export class TransactionListComponentComponent implements OnInit {

  rows : Array<TransactionModel>= [];

  constructor(private transactionApiService:TransactionApiService) { }

  ngOnInit(): void {
  }

  getListTransactions() : void{
    this.transactionApiService.getListTransactions()
    .toPromise()
    .then(data=>{
      this.rows = data
    })
  }
}
