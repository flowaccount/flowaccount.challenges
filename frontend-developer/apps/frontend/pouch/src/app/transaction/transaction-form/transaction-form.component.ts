import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CategoryModel, TransactionModel } from '@typescript/shared/models';
import { first } from 'rxjs/operators';
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
    private transactionApiService: TransactionApiService,
    private dialogRef: MatDialogRef<TransactionFormComponent>
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
      value: [
        null,
        [
          Validators.required,
          Validators.pattern('^-?[1-9]?\\d?(\\.\\d+)?$|(^-?[1-9]\\d+)'),
        ],
      ],
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

    this.onFormStageControl(this.form.valid);

    // stop here if form is invalid
    if (this.form.invalid) {
      return;
    }

    this.loading = true;
    if (this.isAddMode) {
      this.onProcessCreate(this.form.value);
    } else {
      this.onProcessUpdate();
    }
  }

  async onProcessCreate(transaction) {
    await this.transactionApiService
      .create(transaction)
      .pipe(first())
      .subscribe((resp: any) => {
        if (resp.Status) {
          this.onClose(resp);
        }
      });
  }

  onProcessUpdate() {
    return;
  }

  onClose(resp = null) {
    this.dialogRef.close(resp);
  }

  onFormStageControl(stage) {
    if (stage) {
      for (var control in this.form.controls) {
        this.form.controls[control].disable();
      }
    } else {
      for (var control in this.form.controls) {
        this.form.controls[control].enable();
      }
    }
  }
}
