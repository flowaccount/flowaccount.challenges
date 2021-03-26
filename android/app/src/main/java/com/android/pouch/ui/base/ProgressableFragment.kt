package com.android.pouch.ui.base

import android.app.ProgressDialog
import androidx.fragment.app.Fragment

@Suppress("DEPRECATION")
abstract class ProgressableFragment : Fragment() {

    private var progressDialog: ProgressDialog? = null

    protected fun showProgressDialog(show: Boolean) {
        when (show) {
            true -> {
                if (progressDialog == null) {
                    progressDialog = ProgressDialog.show(activity, "", "")
                }
            }
            false -> {
                progressDialog?.dismiss()
                progressDialog = null
            }
        }
    }
}