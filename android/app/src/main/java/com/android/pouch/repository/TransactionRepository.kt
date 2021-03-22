package com.android.pouch.repository

import com.android.pouch.repository.service.TransactionService
import javax.inject.Inject

class TransactionRepository @Inject constructor(
    private val service: TransactionService
): ITransactionRepository {


}