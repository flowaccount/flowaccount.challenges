package com.android.pouch.module

import com.android.pouch.repository.ITransactionRepository
import com.android.pouch.repository.TransactionRepository
import dagger.Binds
import dagger.Module
import dagger.hilt.InstallIn
import dagger.hilt.android.components.ActivityComponent
import dagger.hilt.android.components.ServiceComponent
import dagger.hilt.components.SingletonComponent

@Module
@InstallIn(SingletonComponent::class)
abstract class TransactionModule {

    @Binds
    abstract fun bindTransactionRepository(transactionRepository: TransactionRepository): ITransactionRepository
}