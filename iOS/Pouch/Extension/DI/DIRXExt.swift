//
//  DIRXExt.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation
import Swinject
import RxSwift
import RxCocoa

extension Container {
    func registerRXManager() {
        self.register(RXPublishSubjectManager<[Transaction]>.self) { (_) in
            let transaction = PublishSubject<[Transaction]>()
            return RXPublishSubjectManager(publishSubject: transaction)
        }
    }
}
