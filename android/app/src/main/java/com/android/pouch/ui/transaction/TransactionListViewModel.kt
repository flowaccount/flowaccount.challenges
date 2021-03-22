package com.android.pouch.ui.transaction

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.android.pouch.entity.Transaction
import com.android.pouch.repository.ITransactionRepository
import dagger.hilt.android.lifecycle.HiltViewModel
import kotlinx.coroutines.launch
import javax.inject.Inject

@HiltViewModel
class TransactionListViewModel @Inject constructor(
    transactionRepository: ITransactionRepository
) : ViewModel() {

    val transactions = MutableLiveData<List<Transaction>>()

    init {
        viewModelScope.launch {
            transactions.value = transactionRepository.getTransactions()
        }
    }
}