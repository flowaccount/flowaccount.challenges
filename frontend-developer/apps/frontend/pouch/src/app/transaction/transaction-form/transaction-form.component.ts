import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CategoryModel, TransactionModel } from '@typescript/shared/models';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TransactionApiService } from '../transaction-api-service.service';

@Component({
  selector: 'typescript-transaction-form-component',
  templateUrl: './transaction-form.component.html',
  styleUrls: ['./transaction-form.component.scss'],
})
export class TransactionFormComponent implements OnInit {
  isAddMode: boolean = false;
  transaction: TransactionModel;
  categoryList: CategoryModel[];
  financialTypeList: any[] = [
    { id: 1, name: 'Income' },
    { id: 3, name: 'Expense' },
  ];

  loading: boolean = false;
  submitted = false;

  form: FormGroup;

  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    private formBuilder: FormBuilder,
    private transactionApiService: TransactionApiService
  ) {
    this.transaction = data.transaction;
    this.isAddMode = !this.transaction?.id;
  }

  // convenience getter for easy access to form fields
  get f() {
    return this.form.controls;
  }

  ngOnInit() {
    this.getListCategory();

    this.form = this.formBuilder.group({
      categoryId: [null, Validators.required],
      financialType: [null, Validators.required],
      transactionDate: [new Date(), Validators.required],
      note: [''],
      // value: [0, [Validators.required, Validators.pattern('/-?d*.?d{1,2}/')]],
    });
  }

  getListCategory(): void {
    this.transactionApiService.getListCategory().subscribe((resp) => {
      if (resp.Code === 200) {
        this.categoryList = resp.Data.list;
      } else {
        this.categoryList = [];
      }
    });
  }

  onSubmit() {
    this.submitted = true;

    // reset alerts on submit
    //this.alertService.clear();

    // stop here if form is invalid

    console.log('summited', this.submitted);
    console.log('categoryId', this.form.controls.categoryId);
    if (this.form.invalid) {
      return;
    }

    this.loading = true;
    if (this.isAddMode) {
      //this.createUser();
    } else {
      // this.updateUser();
    }
  }
}
