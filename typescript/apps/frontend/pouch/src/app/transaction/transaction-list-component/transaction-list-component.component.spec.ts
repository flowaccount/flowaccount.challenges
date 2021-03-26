import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TransactionListComponentComponent } from './transaction-list-component.component';

describe('TransactionListComponentComponent', () => {
  let component: TransactionListComponentComponent;
  let fixture: ComponentFixture<TransactionListComponentComponent>;
  // let mockDataList = [
  //   {id: 7075979, name: "", type: 1, categoryName: "Food", categoryId: 1, value: 1000, transactionDate: "20/03/2021" },
  //   {id: 7075979, name: "dinner", type: 1, categoryName: "Food", categoryId: 1, value: 1000, transactionDate: "20/03/2021" }
  // ]

   let mockDataList = undefined

  let mockCategoryList = [
    {  id: 1,  name: "Food", type: 1 },
    {  id: 1,  name: "Pocket Money", type: 3}
  ]

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

  // it('should data list is empty', () => {
  //   expect(mockDataList.length).toBe(0)
  // });

  // it('should data list is not empty', () => {
  //   expect(mockDataList.length).toBeGreaterThan(0)
  // });

  it('should data list is undefined', () => {
    expect(mockDataList).toBeGreaterThan(0)
  });

  it('should data list is null', () => {
    expect(mockDataList).toBeNull()
  });

  it('should data list is undefiend', () => {
    expect(mockDataList).toBeUndefined()
  });


});
