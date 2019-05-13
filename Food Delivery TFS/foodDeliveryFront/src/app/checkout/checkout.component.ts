import { Component, OnInit } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap';
import { AddressModalComponent } from '../address-modal/address-modal.component';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {
  bsModalRef: BsModalRef;
  time: string;
  myDeliveryAddress: string;
  creditCardPayment = true;
  cachPayment = false;
  visaPayment = false;

  constructor(public addressModalService: BsModalService) { }

  ngOnInit() {}

  selectAddress() {
    this.bsModalRef = this.addressModalService.show(AddressModalComponent, {class: 'modal-lg' });
    this.bsModalRef.content.addressSelected.subscribe(resp => {
      this.myDeliveryAddress = resp;
    }, error => {
      console.log(error);
    });
  }
  

  panelClicked(type: string) {
    switch (type) {
      case 'credit card':
        this.creditCardPayment = true;
        this.cachPayment = false;
        this.visaPayment = false;
      break;
      case 'visa':
        this.creditCardPayment = false;
        this.visaPayment = true;
        this.cachPayment = false;
      break;
      case 'cach':
        this.creditCardPayment = false;
        this.visaPayment = false;
        this.cachPayment = true;
      break;

    }
  }
}
