//
//  TransactionViewModel.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation

class TransactionViewModel: ITransactionViewModel {
    
    private var apiService: TransactionAPI!
    private var rxTransaction: RXPublishSubjectManager<[TransactionViewModel]>!
    private var model: Transaction!
    
    init(model: Transaction, apiService: TransactionAPI, rx: RXPublishSubjectManager<[TransactionViewModel]>) {
        self.model = model
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
    
    private func getCurrent() -> Transaction {
        return model
    }
    
    private func getTransactionList() {
        let params = getCurrent().toJSON()
        self.apiService.getList(params: params) { (models: [Transaction]) in
            let viewModels = models.map( { TransactionViewModel(model: $0, apiService: self.apiService, rx: self.rxTransaction) } )
            self.rxTransaction.onNext(viewModels)
        }
    }
}
   
