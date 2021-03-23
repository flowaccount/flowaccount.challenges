package com.android.pouch.ui.transaction.list

import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.android.pouch.entity.Transaction

class TransactionListAdapter(
        private val dataSet: List<Transaction>
): RecyclerView.Adapter<TransactionListAdapter.ViewHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        TODO("Not yet implemented")
    }

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        TODO("Not yet implemented")
    }

    override fun getItemCount(): Int {
        TODO("Not yet implemented")
    }

    class ViewHolder(view: View): RecyclerView.ViewHolder(view) {

    }
}