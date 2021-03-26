import { TransactionType } from "../enums/transaction.enum"

export class TransactionModel{
    CategoryId :number
    TransactionDate :Date
    Name:string
    Type: TransactionType
    Value:number
    IsDelete: boolean
    Status :number
    Note:string
    CreatedOn:Date
    ModifiedOn:Date
}