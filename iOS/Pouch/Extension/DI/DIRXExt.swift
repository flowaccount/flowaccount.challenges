//
//  DIRXExt.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation
import Swinject

extension Container {
    func registerRXManager() {
        self.register(RXPublishSubjectManager<Int>.self) { _ in
            let delegate = UIApplication.shared.delegate as! AppDelegate
            return RXPublishSubjectManager(publishSubject: delegate.publishSubject)
        }
    }
}
