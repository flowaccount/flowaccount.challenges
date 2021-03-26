//
//  API.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation
import Alamofire

class API {
    
    init() {
        // unimplement
    }
    
    func httpRequest<T: BaseAPIResponse>(endpoint: String, method: Alamofire.HTTPMethod, parameters: Parameters?, encoding: ParameterEncoding = URLEncoding.default, isLoading: Bool = true, completion:@escaping (AFDataResponse<T>) -> Void)   {
        print(endpoint)
    }
}
