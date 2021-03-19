package com.android.pouch.di

import com.android.pouch.ui.transaction.TransactionViewModel
import org.koin.androidx.viewmodel.dsl.viewModel
import org.koin.dsl.module

val viewModelModule = module {
    viewModel { TransactionViewModel() }
}