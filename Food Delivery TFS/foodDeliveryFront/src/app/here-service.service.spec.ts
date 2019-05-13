/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { HereServiceService } from './here-service.service';

describe('Service: HereService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HereServiceService]
    });
  });

  it('should ...', inject([HereServiceService], (service: HereServiceService) => {
    expect(service).toBeTruthy();
  }));
});
