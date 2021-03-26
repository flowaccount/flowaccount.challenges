//
//  TransactionViewModel.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation

class TransactionViewModel: ITransactionViewModel {
    
    private var apiService: TransactionAPI!
    private var model: Transaction!
    
    init(model: Transaction, apiService: TransactionAPI) {
        self.model = model
        self.apiService = apiService
    }
}
