//
//  BaseAPIResponse.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation
import ObjectMapper

public class BaseAPIResponse: Mappable {
    
    public var status: Bool = false
    public var message: String = String()
    public var exceptionMessage: String?
    public var code: Int = 0
    
    init() {
        self.status = false
        self.message = String()
        self.code = 0
    }
    
    required public init?(map: Map){
        // unimplement
    }
    
    public func mapping(map: Map) {
        self.status <- map["status"]
        self.message <- map["message"]
        self.code <- map["code"]
    }
}

