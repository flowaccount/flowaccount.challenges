import { FinancialType } from '../enums/transaction.enum';
import { CategoryModel } from './transactionModel';

export class TransactionModel {
  id: number;
  categoryId: number;
  transactionDate: Date;
  name: string;
  financialType: number;
  value: number;
  isDelete: boolean;
  status: number;
  note?: string;
  createdOn: Date;
  modifiedOn: Date;

  category: CategoryModel;
  financialTypeName: string;
}
