import { FinancialType } from "../enums/transaction.enum"

export class TransactionModel{
    id: number;
    categoryId :number
    transactionDate :Date
    name:string
    financialType: number;
    value:number
    isDelete: boolean
    status :number
    note?:string
    createdOn:Date
    modifiedOn:Date;

    category : CategoryModel;
    financialTypeName : string;
}

export class CategoryModel {
    id : number;
    name : string;
}
