import { TestBed } from '@angular/core/testing';

import { TransactionApiService } from './transaction-api-service.service';

describe('TransactionApiServiceService', () => {
  let service: TransactionApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TransactionApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
  
});
