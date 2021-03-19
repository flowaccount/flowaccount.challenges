package com.android.pouch.ui.wallet

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.fragment.app.Fragment
import androidx.lifecycle.Observer
import androidx.lifecycle.ViewModelProvider
import com.android.pouch.R

class WalletFragment : Fragment() {

    private lateinit var walletViewModel: WalletViewModel

    override fun onCreateView(
            inflater: LayoutInflater,
            container: ViewGroup?,
            savedInstanceState: Bundle?
    ): View? {
        walletViewModel =
                ViewModelProvider(this).get(WalletViewModel::class.java)
        val root = inflater.inflate(R.layout.fragment_wallet, container, false)
        val textView: TextView = root.findViewById(R.id.text_wallet)
        walletViewModel.text.observe(viewLifecycleOwner, Observer {
            textView.text = it
        })
        return root
    }
}