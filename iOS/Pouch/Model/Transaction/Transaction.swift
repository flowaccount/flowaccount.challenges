//
//  Transaction.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation
import ObjectMapper

class Transaction: NSObject, NSCoding, Mappable {
    
    var id: Int = 0
    var imageUrl: String = ""
    var type: TransactionType = .expense
    var category: String = ""
    var price: Double = 0.0
    var createdDate: Data = Data()
    var updatedDate: Date = Date()
    
    func mapping(map: Map) {
        id <- map["id"]
        imageUrl <- map["imageUrl"]
        type <- map["type"]
        category <- map["category"]
        price <- map["price"]
        createdDate <- map["createdDate"]
        updatedDate <- map["updatedDate"]
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

