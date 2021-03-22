package com.android.pouch.repository

import com.android.pouch.entity.Transaction

interface ITransactionRepository {

    suspend fun getTransactions(): List<Transaction>
}