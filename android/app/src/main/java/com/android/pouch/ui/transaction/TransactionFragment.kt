package com.android.pouch.ui.transaction

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.fragment.app.Fragment
import androidx.lifecycle.Observer
import androidx.lifecycle.ViewModelProvider
import com.android.pouch.R

class TransactionFragment : Fragment() {

    private lateinit var transactionViewModel: TransactionViewModel

    override fun onCreateView(
            inflater: LayoutInflater,
            container: ViewGroup?,
            savedInstanceState: Bundle?
    ): View? {
        transactionViewModel =
                ViewModelProvider(this).get(TransactionViewModel::class.java)
        val root = inflater.inflate(R.layout.fragment_transaction, container, false)
        val textView: TextView = root.findViewById(R.id.text_transaction)
        transactionViewModel.text.observe(viewLifecycleOwner, Observer {
            textView.text = it
        })
        return root
    }
}