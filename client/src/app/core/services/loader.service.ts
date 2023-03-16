import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root'
})
export class LoaderService {
  loaderRequestCount = 0;

  constructor(private spinnerService: NgxSpinnerService) { }

  load() {
    this.loaderRequestCount++;
    this.spinnerService.show(undefined, {
      type: 'ball-spin-clockwise-fade',
      bdColor: 'rgba(255, 255, 255, 0.7)',
      color: '#333'
    })
  }

  idle() {
    this.loaderRequestCount--;
    if (this.loaderRequestCount <= 0) {
      this.loaderRequestCount = 0;
      this.spinnerService.hide();
    }
  }
}
