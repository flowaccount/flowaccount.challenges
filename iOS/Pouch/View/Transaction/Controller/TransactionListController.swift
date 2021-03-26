//
//  TransactionController.swift
//  Pouch
//
//  Created by pongpanich raksa on 26/3/2564 BE.
//

import Foundation
import UIKit

class TransactionListController: BaseViewController {
    
    struct RawCell {
        static let summaryCell = "TransactionSummaryCell"
        static let detailCell = "TransactionDetailCell"
    }
    
    @IBOutlet var coll: UICollectionView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        self.registerCell()
    }
    
    private func registerCell() {
        coll.register(UINib(nibName: RawCell.summaryCell, bundle: nil), forCellWithReuseIdentifier: RawCell.summaryCell)
        coll.register(UINib(nibName: RawCell.detailCell, bundle: nil), forCellWithReuseIdentifier: RawCell.detailCell)
        coll.delegate = self
        coll.dataSource = self
    }
    
}

extension TransactionListController: UICollectionViewDelegate, UICollectionViewDataSource, UICollectionViewDelegateFlowLayout {
    func collectionView(_ collectionView: UICollectionView, numberOfItemsInSection section: Int) -> Int {
        return 10
    }
    
    func collectionView(_ collectionView: UICollectionView, cellForItemAt indexPath: IndexPath) -> UICollectionViewCell {
        let cell = collectionView.dequeueReusableCell(withReuseIdentifier: RawCell.summaryCell, for: indexPath) as! TransactionSummaryCell
        return cell
    }
    
    func collectionView(_ collectionView: UICollectionView, layout collectionViewLayout: UICollectionViewLayout, sizeForItemAt indexPath: IndexPath) -> CGSize {
        return CGSize(width: collectionView.frame.width, height: 120)
    }
}
