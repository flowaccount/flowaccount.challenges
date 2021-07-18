import { CategoryModel } from './categoryModel';

export class TransactionModel {
  id: number;
  categoryId: number;
  transactionDate: Date;
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
