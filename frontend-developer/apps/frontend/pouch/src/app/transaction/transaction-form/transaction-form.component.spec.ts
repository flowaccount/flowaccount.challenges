import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TransactionFormComponentComponent } from './transaction-form.component';

describe('TransactionFormComponentComponent', () => {
  let component: TransactionFormComponentComponent;
  let fixture: ComponentFixture<TransactionFormComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TransactionFormComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TransactionFormComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
