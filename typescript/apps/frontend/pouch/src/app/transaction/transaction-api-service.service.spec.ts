import { TestBed } from '@angular/core/testing';

import { TransactionApiServiceService } from './transaction-api-service.service';

describe('TransactionApiServiceService', () => {
  let service: TransactionApiServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TransactionApiServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
