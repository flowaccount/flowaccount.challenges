//
//  DIModelExt.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation
import Swinject

extension Container {
    func registerModel() {
        self.register(Transaction.self) { (_) in
            return Transaction()
        }
        self.register(Summary.self)  { (_) in
            return Summary()
        }
    }
}

