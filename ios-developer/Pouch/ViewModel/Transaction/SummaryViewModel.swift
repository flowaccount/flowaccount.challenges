//
//  SummaryViewModel.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation

class SummaryViewModel: ISummaryViewModel {
    
    private var apiService: TransactionAPI!
    private var model: Summary!
    
    init(model: Summary, apiService: TransactionAPI) {
        self.model = model
        self.apiService = apiService
    }
}
