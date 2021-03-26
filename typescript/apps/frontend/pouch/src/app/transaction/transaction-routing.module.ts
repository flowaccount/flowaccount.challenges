import { NgModule } from "@angular/core";
import { Route, RouterModule, Routes } from "@angular/router";
import { TransactionListComponentComponent } from "./transaction-list-component/transaction-list-component.component";


export const transactionIndexState: Route = {
    path: 'transaction',
    children: [
      { path: '', component: TransactionListComponentComponent }
    ],
  }

const routes: Routes = [transactionIndexState]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class TransactionRoutingModule { }
