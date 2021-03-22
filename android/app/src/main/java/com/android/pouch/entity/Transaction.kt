package com.android.pouch.entity

import com.google.gson.annotations.SerializedName

data class Transaction(
    @SerializedName("amount") var amount: Double
)
