package com.android.pouch.repository

import com.android.pouch.entity.Transaction
import com.android.pouch.repository.service.TransactionService
import javax.inject.Inject

class TransactionRepository @Inject constructor(
    private val service: TransactionService
): ITransactionRepository {

    override suspend fun getTransactions(): List<Transaction> {
        // get from cache
        // if null get from service
        // update cache
        // return
        return service.getTransactions().data
    }
}