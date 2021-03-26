//
//  TransactionViewModel.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation

class TransactionViewModel: ITransactionViewModel {
    
    private var apiService: TransactionAPI!
    private var rxTransaction: RXPublishSubjectManager<[Transaction]>!
    
    init(apiService: TransactionAPI, rx: RXPublishSubjectManager<[Transaction]>) {
        self.apiService = apiService
        self.rxTransaction = rx
        self.getTransactionList()
    }
    
    func getBalance() -> String {
        return "200.00 บาท"
    }
    
    func getUserName() -> String {
        return "Test User"
    }
    
    private func getTransactionList() {
        var params: [String: Any] = [:]
        params["test"] = 0
        self.apiService.getList(params: params) { (transactions: [Transaction]) in
            self.rxTransaction.onNext(transactions)
        }
    }
}
   
