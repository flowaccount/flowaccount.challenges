import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TransactionModel } from '@typescript/shared/models';
import { of } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class TransactionApiService {
  constructor(private httpClient: HttpClient) {}

  getListTransactions() {
    const endpoint = 'http://localhost:4000/api/Transaction';
    return this.httpClient.get<any>(endpoint).pipe(
      catchError((err) => {
        return of({
          status: false,
          message: err.message,
        });
      })
    );
  }

  create(obj: TransactionModel) {
    const endpoint = 'http://localhost:4000/api/Transaction';
    return this.httpClient.post(endpoint, obj).pipe(
      catchError((err) => {
        return of({
          status: false,
          message: err.message,
        });
      })
    );
  }

  getListCategory() {
    const endpoint = 'http://localhost:4000/api/Category';
    return this.httpClient.get<any>(endpoint).pipe(
      catchError((err) => {
        return of({
          status: false,
          message: err.message,
        });
      })
    );
  }
}
