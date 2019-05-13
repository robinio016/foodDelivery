/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { HereService } from './here.service';

describe('Service: Here', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HereService]
    });
  });

  it('should ...', inject([HereService], (service: HereService) => {
    expect(service).toBeTruthy();
  }));
});
