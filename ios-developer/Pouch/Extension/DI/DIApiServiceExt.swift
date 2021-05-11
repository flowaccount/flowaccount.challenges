//
//  DIApiServiceExt.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation

import Foundation
import Swinject

extension Container {
    func registerApiService() {
        //        self.register(API.self) { (_) in
        //            return API()
        //        }
        self.register(TransactionAPI.self) { _ in
            return TransactionAPI()
        }
    }
}
