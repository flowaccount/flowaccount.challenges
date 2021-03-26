//
//  UIViewExt.swift
//  Pouch
//
//  Created by pongpanich raksa on 26/3/2564 BE.
//

import Foundation
import UIKit

extension UIView {
    
    @IBInspectable var radiusView: CGFloat {
        set (key) {
            self.layer.cornerRadius = key
        }
        get {
            return 0.0
        }
    }
    
}
