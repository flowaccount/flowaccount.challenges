import { TransactionType } from "../enums/transaction.enum"

export class TransactionModel{
    categoryId :number
    transactionDate :Date
    name:string
    type: TransactionType
    value:number
    isDelete: boolean
    status :number
    note:string
    createdOn:Date
    modifiedOn:Date
}