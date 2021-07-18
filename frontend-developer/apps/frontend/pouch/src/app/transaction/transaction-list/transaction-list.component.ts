import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { TransactionModel } from '@typescript/shared/models';
import { FinancialType } from 'libs/shared/models/src/lib/enums/transaction.enum';
import { TransactionApiService } from '../transaction-api-service.service';
import { TransactionFormComponent } from '../transaction-form/transaction-form.component';

@Component({
  selector: 'typescript-transaction-list-component',
  templateUrl: './transaction-list.component.html',
  styleUrls: ['./transaction-list.component.scss'],
})
export class TransactionListComponent implements OnInit {
  public transactionList: TransactionModel[] = [];
  public totalIncome: number = 0;
  public totalExpense: number = 0;
  public balance: number = 0;

  constructor(
    private transactionApiService: TransactionApiService,
    private dialog: MatDialog
  ) {}

  openTransactionFormDialog(trans = {}) {
    const result = this.dialog.open(TransactionFormComponent, {
      width: '500px',
      data: {
        transaction: trans,
      },
    });

    result.afterClosed().subscribe((resp) => {
      if (resp?.Status) {
        this.getListTransactions();
      }
    });
  }

  ngOnInit(): void {
    this.getListTransactions();
  }

  getListTransactions(): void {
    this.transactionApiService
      .getListTransactions()
      .toPromise()
      .then((resp) => {
        if (resp.Code === 200) {
          this.transactionList = resp.Data.list.map((x) => {
            x.financialTypeName = FinancialType[x.financialType];
            return x;
          });
        } else {
          this.transactionList = [];
        }

        this.summaryTransaction();

        console.log(this.transactionList);
      });
  }

  summaryTransaction() {
    this.transactionList.map((x) => {
      switch (x.financialType) {
        case 1:
          {
            this.totalIncome += x.value;
          }
          break;
        case 3:
          {
            this.totalExpense += x.value;
          }
          break;
      }
    });

    this.balance = this.totalIncome - this.totalExpense;
  }
}
