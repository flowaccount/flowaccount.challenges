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
    // this.getListTransactions()
    this.rows = [{
      categoryId :1 ,
      transactionDate :null,
      name:'string',
      type: 1,
      value:2,
      isDelete: false,
      status :1,
      note:'string',
      createdOn:null,
      modifiedOn:null
    },{
      categoryId :1 ,
      transactionDate :null,
      name:'string',
      type: 1,
      value:2,
      isDelete: false,
      status :1,
      note:'string',
      createdOn:null,
      modifiedOn:null
    }]
  }

  getListTransactions() : void{
    this.transactionApiService.getListTransactions()
    .toPromise()
    .then(data=>{
      this.rows = data
    })
  }
}
