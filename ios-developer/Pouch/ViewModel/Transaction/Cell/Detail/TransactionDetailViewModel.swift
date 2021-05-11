//
//  TransactionDetailViewModel.swift
//  Pouch
//
//  Created by Narong Kanthanu on 2/4/2564 BE.
//

import Foundation

class TransactionDetailViewModel: ITransactionDetailViewModel {
    
    private var date: Date!
    private var category: String!
    private var transactionType: TransactionType!
    private var price: Double = 0.0
    
    init(date: Date, category: String, transactionType: TransactionType, price: Double) {
        self.date = date
        self.category = category
        self.transactionType = transactionType
        self.price = price
    }
    
    func getDateForDisplay() -> String {
        return ""
    }
    
    func getDayForDisplay() -> String {
        return ""
    }
    
    func getMonthAndYearForDisplay() -> String {
        return ""
    }
    
    func getCategoryForDisplay() -> String {
        return ""
    }
    
    func getTransactionTypeForDisplay() -> String {
        return ""
    }
    
    func getPriceForDisplay() -> String {
        return "\(price) THB"
    }
    
    func getHexColorByTransactionType() -> Int {
        return 0x32a852
    }
}
