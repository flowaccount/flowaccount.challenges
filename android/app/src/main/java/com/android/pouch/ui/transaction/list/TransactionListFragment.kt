package com.android.pouch.ui.transaction.list

import android.os.Bundle
import android.util.Log
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import androidx.fragment.app.viewModels
import androidx.navigation.fragment.findNavController
import com.android.pouch.R
import com.android.pouch.databinding.FragmentTransactionListBinding
import dagger.hilt.android.AndroidEntryPoint

@AndroidEntryPoint
class TransactionListFragment : Fragment() {

    private val viewModel: TransactionListViewModel by viewModels()
    private lateinit var binding: FragmentTransactionListBinding

    override fun onCreateView(
            inflater: LayoutInflater, container: ViewGroup?,
            savedInstanceState: Bundle?
    ): View {
        binding = FragmentTransactionListBinding.inflate(LayoutInflater.from(context), container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        viewModel.transactions.observe(viewLifecycleOwner) { transitions ->
            binding.transactionList.adapter = TransactionListAdapter(transitions)
        }

        binding.fab.setOnClickListener {
            findNavController().navigate(R.id.action_TransactionListFragment_to_TransactionDetailFragment)
        }
    }
}