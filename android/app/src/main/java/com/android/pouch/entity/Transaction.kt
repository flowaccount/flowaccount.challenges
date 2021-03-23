package com.android.pouch.entity

import com.google.gson.annotations.SerializedName
import java.util.*

data class Transaction(
        @SerializedName("id") var id: Long,
        @SerializedName("type") var type: TransactionType,
        @SerializedName("category") var category: String,
        @SerializedName("amount") var amount: Double,
        @SerializedName("createdAt") var createdAt: Calendar
)
