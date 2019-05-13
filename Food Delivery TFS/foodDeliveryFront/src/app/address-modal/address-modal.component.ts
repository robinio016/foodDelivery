import { Component, OnInit, ViewChild, NgZone, EventEmitter, Output } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap';
import { MouseEvent} from '@agm/core';
import { Subject } from 'rxjs';
import { HereService } from '../_services/here.service';



@Component({
  selector: 'app-address-modal',
  templateUrl: './address-modal.component.html',
  styleUrls: ['./address-modal.component.css']
})
export class AddressModalComponent implements OnInit {
  @Output() addressSelected = new EventEmitter<string>();
  public query: string;
  public position: string;
  public locations: Array<any>;
  isMapsToShow = true;
  homeTypeLocation = 'appartement';
  marker: Marker = { lng: 9.864,
                     lat: 37.2768,
                     draggable: true
                  };
  // lat = 37.2768;
  // lng = 9.864;
  public currentAddress: string;

  constructor(public bsModalRef: BsModalRef, private here: HereService) {
        this.query = 'Tracy, CA';
        this.position = '37.7397,-121.4252';
  }

  ngOnInit() {

    if (navigator) {
    navigator.geolocation.getCurrentPosition( pos => {
        this.marker.lng = +pos.coords.longitude;
        this.marker.lat = +pos.coords.latitude;
        this.position = this.marker.lat + ',' + this.marker.lng;
        this.getAddressFromLatLng();
      });
    }
  }

  public getAddress() {
    if (this.query !== '') {
        this.here.getAddress(this.query).then(result => {
            this.locations = <Array<any>>result;
        }, error => {
            console.error(error);
        });
    }
}

public getAddressFromLatLng() {
  if (this.position !== '') {
      this.here.getAddressFromLatLng(this.position).then(result => {
          this.locations = <Array<any>>result;
          console.log(this.locations);
          console.log(this.locations[0]);
          this.currentAddress = this.locations[0].Location.Address.Label;
      }, error => {
          console.error(error);
      });
  }
}
  mapClicked($event: MouseEvent) {
    this.marker = {
      lat: $event.coords.lat,
      lng: $event.coords.lng,
      draggable: true
    };
  }

  markerDragEnd(m: Marker, $event: MouseEvent) {

    this.marker.lat = $event.coords.lat;
    this.marker.lng = $event.coords.lng;
    this.position = this.marker.lat + ',' + this.marker.lng;
    console.log(this.position);
    this.getAddressFromLatLng();
  }
  confirm() {
    this.addressSelected.emit(this.currentAddress);
    this.bsModalRef.hide();
  }

  cancel() {
    this.bsModalRef.hide();
  }

}

interface Marker {
  lat: number;
  lng: number;
  label?: string;
  draggable: boolean;
}
