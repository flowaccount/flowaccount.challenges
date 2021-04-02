//
//  TransactionController.swift
//  Pouch
//
//  Created by pongpanich raksa on 26/3/2564 BE.
//

import Foundation
import UIKit

class TransactionListController: BaseViewController {
    
    struct rawCell {
        static let summaryCell = "TransactionSummaryCell"
        static let detailCell = "TransactionDetailCell"
    }
    
    @IBOutlet var coll: UICollectionView!
    
    private lazy var viewModel: TransactionViewModel = {
        return appDelegate.container.resolve(TransactionViewModel.self)!
    }()
    
    override func viewDidLoad() {
        super.viewDidLoad()
        self.registerCell()
    }
    
    private func registerCell() {
        coll.register(UINib(nibName: rawCell.summaryCell, bundle: nil), forCellWithReuseIdentifier: rawCell.summaryCell)
        coll.register(UINib(nibName: rawCell.detailCell, bundle: nil), forCellWithReuseIdentifier: rawCell.detailCell)
        coll.delegate = self
        coll.dataSource = self
    }
}

extension TransactionListController: UICollectionViewDelegate, UICollectionViewDataSource, UICollectionViewDelegateFlowLayout {
    func collectionView(_ collectionView: UICollectionView, numberOfItemsInSection section: Int) -> Int {
        return 10
    }
    
    func collectionView(_ collectionView: UICollectionView, cellForItemAt indexPath: IndexPath) -> UICollectionViewCell {
        if indexPath.row == 0 {
            let cell = collectionView.dequeueReusableCell(withReuseIdentifier: rawCell.summaryCell, for: indexPath) as! TransactionSummaryCell
            return cell
        } else {
            let cell = collectionView.dequeueReusableCell(withReuseIdentifier: rawCell.detailCell, for: indexPath) as! TransactionDetailCell
            return cell
        }
    }
    
    func collectionView(_ collectionView: UICollectionView, layout collectionViewLayout: UICollectionViewLayout, sizeForItemAt indexPath: IndexPath) -> CGSize {
        if indexPath.row == 0 {
            return CGSize(width: collectionView.frame.width, height: 120)
        } else {
            return CGSize(width: collectionView.frame.width, height: 156)
        }
    }
}
