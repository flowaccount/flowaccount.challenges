//
//  DIViewModelExt.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation
import Swinject

extension Container {
    func registerViewModel() {
        self.register(TransactionViewModel.self) { (r) in
            return TransactionViewModel(apiService: r.resolve(TransactionAPI.self)!, rx: r.resolve(RXPublishSubjectManager<[Transaction]>.self)!)
        }
        self.register(SummaryViewModel.self) { (r) in
            return SummaryViewModel(model: r.resolve(Summary.self)!, apiService: r.resolve(TransactionAPI.self)!)
        }
    }
}
