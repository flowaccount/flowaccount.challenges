package com.android.pouch.ui.transaction.list

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.android.pouch.databinding.ItemTransactionBinding
import com.android.pouch.entity.Transaction

class TransactionListAdapter(
        private val dataSet: List<Transaction>
): RecyclerView.Adapter<TransactionListAdapter.ViewHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val binding = ItemTransactionBinding.inflate(LayoutInflater.from(parent.context), parent, false)
        return ViewHolder(binding)
    }

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        holder.bind(dataSet[position])
    }

    override fun getItemCount(): Int {
        return dataSet.size
    }

    class ViewHolder(private val binding: ItemTransactionBinding): RecyclerView.ViewHolder(binding.root) {

        fun bind(model: Transaction) {
            binding.transactionDate.text = model.id.toString()
            binding.transactionCategory.text = model.category
            binding.transactionAmount.text = model.amount.toString()
        }
    }
}