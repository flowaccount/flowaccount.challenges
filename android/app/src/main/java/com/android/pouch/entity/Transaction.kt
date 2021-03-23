package com.android.pouch.entity

import com.google.gson.annotations.SerializedName

data class Transaction(
        @SerializedName("id") var id: Long,
        @SerializedName("type") var type: Int,
        @SerializedName("category") var category: String,
        @SerializedName("amount") var amount: Double,
        @SerializedName("createdAt") var createdAt: String
)
