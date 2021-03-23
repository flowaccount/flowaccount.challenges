package com.android.pouch.repository.service

import com.android.pouch.entity.BaseAPIResponse
import com.android.pouch.entity.Transaction
import retrofit2.http.GET

interface TransactionService {

    /**
     * HTTP GET request for transactions
     */
    @GET("/transactions")
    suspend fun getTransactions(): BaseAPIResponse<List<Transaction>>
}