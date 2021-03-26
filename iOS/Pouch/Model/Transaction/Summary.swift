//
//  Summary.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation
import ObjectMapper

class Summary: NSObject, NSCoding, Mappable {
    
    var id: Int = 0
    var totalIncome: Double = 0.0
    var totalExpense: Double = 0.0
    var balance: Double = 0.0
    var createdDate: Data = Data()
    var updatedDate: Date = Date()
    
    func mapping(map: Map) {
        id <- map["id"]
        totalIncome <- map["totalIncome"]
        totalExpense <- map["totalExpense"]
        balance <- map["balance"]
        createdDate <- map["createdDate"]
        updatedDate <- map["updatedDate"]
    }
    
    override init() {
        // unimplement
    }
    
    required init?(map: Map) {
        // unimplement
    }
    
    required init?(coder aDecoder: NSCoder) {
        // unimplement
    }
    
    func encode(with aCoder: NSCoder) {
        // unimplement
    }
    
    convenience init?(data: [String:Any]){
        self.init(JSON: data)
    }
}
