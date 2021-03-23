package com.android.pouch.entity

import com.google.gson.annotations.SerializedName

data class BaseAPIResponse<T>(
    @SerializedName("status") val status: Boolean,
    @SerializedName("data") val data: T
)
