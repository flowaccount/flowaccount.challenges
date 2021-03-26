package com.android.pouch.ui.transaction.list

import androidx.navigation.Navigation
import androidx.navigation.testing.TestNavHostController
import androidx.test.core.app.ApplicationProvider
import androidx.test.espresso.Espresso.onView
import androidx.test.espresso.IdlingRegistry
import androidx.test.espresso.action.ViewActions.click
import androidx.test.espresso.assertion.ViewAssertions.matches
import androidx.test.espresso.matcher.ViewMatchers.*
import com.android.pouch.MockServerDispatcher
import com.android.pouch.R
import com.android.pouch.util.TestUtils.withRecyclerView
import com.android.pouch.launchFragmentInHiltContainer
import com.android.pouch.module.NetworkModule
import com.jakewharton.espresso.OkHttp3IdlingResource
import dagger.hilt.android.testing.HiltAndroidRule
import dagger.hilt.android.testing.HiltAndroidTest
import dagger.hilt.android.testing.UninstallModules
import kotlinx.coroutines.ExperimentalCoroutinesApi
import okhttp3.OkHttpClient
import okhttp3.mockwebserver.MockWebServer
import org.hamcrest.CoreMatchers.equalTo
import org.junit.After
import org.junit.Before
import org.junit.Rule
import org.junit.Test
import javax.inject.Inject

@ExperimentalCoroutinesApi
@UninstallModules(NetworkModule::class)
@HiltAndroidTest
class TransactionListFragmentTest {

    @get:Rule
    val hiltRule = HiltAndroidRule(this)

    private val navController = TestNavHostController(ApplicationProvider.getApplicationContext())

    private lateinit var mockWebServer: MockWebServer

    @Inject lateinit var okHttp: OkHttpClient

    @Before
    fun setUp() {
        hiltRule.inject()
        mockWebServer = MockWebServer()
        mockWebServer.dispatcher = MockServerDispatcher().RequestDispatcher()
        mockWebServer.start(8080)
        IdlingRegistry.getInstance().register(OkHttp3IdlingResource.create("okhttp", okHttp))
    }

    @After
    fun tearDown() {
        mockWebServer.shutdown()
    }

    @Test
    fun showCorrectTransactionList() {
        launchTransactionListFragment()

        onView(withRecyclerView(R.id.transaction_list)
                .atPositionOnView(0, R.id.transaction_date))
                .check(matches(withText("1")))

        onView(withRecyclerView(R.id.transaction_list)
                .atPositionOnView(0, R.id.transaction_amount))
                .check(matches(withText("200.0")))
    }

    @Test
    fun clickAddTransactionButtonThenNavigateToTransactionDetail() {
        launchTransactionListFragment()

        onView(withId(R.id.create_transaction_fab)).perform(click())

        assertThat(navController.currentDestination?.id, equalTo(R.id.TransactionDetailFragment))
    }

    private fun launchTransactionListFragment() {
        launchFragmentInHiltContainer<TransactionListFragment> {
            navController.setGraph(R.navigation.nav_graph)
            navController.setCurrentDestination(R.id.TransactionListFragment)
            this.viewLifecycleOwnerLiveData.observeForever { viewLifeCycleOwner ->
                if (viewLifeCycleOwner != null) {
                    Navigation.setViewNavController(this.requireView(), navController)
                }
            }
        }
    }
}