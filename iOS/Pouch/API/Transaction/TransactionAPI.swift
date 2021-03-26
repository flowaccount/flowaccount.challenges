//
//  TransactionAPI.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation
import Alamofire
import ObjectMapper

class TransactionAPI: API {
    public func getList(params: [String: Any], completionHandler:@escaping ([Transaction]) -> Void) {
        self.httpRequest(endpoint: "", method: .get, parameters: params) { (response: AFDataResponse<APIResponseArray2<Transaction>>) in
            completionHandler(response.value?.data ?? [Transaction]())
        }
    }
}
