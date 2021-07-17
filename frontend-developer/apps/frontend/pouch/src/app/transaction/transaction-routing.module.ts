import { NgModule } from "@angular/core";
import { Route, RouterModule, Routes } from "@angular/router";
import { TransactionListComponent } from "./transaction-list/transaction-list.component";


export const transactionIndexState: Route = {
    path: '',
    component: TransactionListComponent
}

const routes: Routes = [transactionIndexState]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class TransactionRoutingModule { }
