//
//  APIResponseArray.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation

import Foundation
import ObjectMapper

public class APIResponseArray2<T: Mappable> : BaseAPIResponse {
    public var data: [T]?
    public var total: Int?
    public var statusCode: Int?
    
    public required init?(map: Map) {
        super.init(map: map)
    }
    
    public override func mapping(map: Map) {
        super.mapping(map: map)
        
        self.data <- map["data.list"]
        self.total <- map["data.total"]
        self.statusCode <- map["code"]
    }
}
