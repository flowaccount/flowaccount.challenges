//
//  DateExt.swift
//  Pouch
//
//  Created by Narong Kanthanu on 2/4/2564 BE.
//

import Foundation

extension Date {
    func parseToStringBCMonth(language: String = "en") -> String {
        let dateFormatterYear = DateFormatter()
        dateFormatterYear.locale = Locale(identifier: language)
        dateFormatterYear.dateFormat = "MMM"
        return dateFormatterYear.string(from: self)
    }
    
    func parseToStringBCFormat(dateFormat: String) -> String {
        let dateFormatterYear = DateFormatter()
        dateFormatterYear.locale = Locale(identifier: "en")
        dateFormatterYear.dateFormat = dateFormat
        return dateFormatterYear.string(from: self)
    }
}
