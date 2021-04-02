//
//  ITransactionDetailViewModel.swift
//  Pouch
//
//  Created by Narong Kanthanu on 2/4/2564 BE.
//

import Foundation

protocol ITransactionDetailViewModel {
    func getDateForDisplay() -> String
    func getDayForDisplay() -> String
    func getMonthAndYearForDisplay() -> String
    func getCategoryForDisplay() -> String
    func getTransactionTypeForDisplay() -> String
    func getPriceForDisplay() -> String
    func getHexColorByTransactionType() -> Int
}
