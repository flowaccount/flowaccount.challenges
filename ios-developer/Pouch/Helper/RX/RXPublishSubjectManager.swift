//
//  RXPublishSubjectManager.swift
//  Pouch
//
//  Created by Narong Kanthanu on 26/3/2564 BE.
//

import Foundation
import RxCocoa
import RxSwift

class RXPublishSubjectManager<T> {
    
    private var publishSubject: PublishSubject<T>
    private var subscribe: Disposable!
    
    init(publishSubject: PublishSubject<T>) {
        self.publishSubject = publishSubject
    }
    
    func addSubscribe(completionHandler: @escaping (T) -> Void) {
        subscribe = publishSubject.asObserver()
            .subscribe { (value: T) in
                completionHandler(value)
            }
    }
    
    func removeSubscribe() {
        subscribe.dispose()
    }
    
    func onNext(_ value: T) {
        publishSubject.onNext(value)
    }
}
