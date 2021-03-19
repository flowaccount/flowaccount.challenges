import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TransactionListComponentComponent } from './transaction-list-component.component';

describe('TransactionListComponentComponent', () => {
  let component: TransactionListComponentComponent;
  let fixture: ComponentFixture<TransactionListComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TransactionListComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TransactionListComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
