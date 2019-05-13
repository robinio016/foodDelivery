import { Component, OnInit } from '@angular/core';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { IngredientToAddModalComponent } from './ingredient-to-add-modal/ingredient-to-add-modal.component';

@Component({
  selector: 'app-restaurant',
  templateUrl: './restaurant.component.html',
  styleUrls: ['./restaurant.component.css']
})
export class RestaurantComponent implements OnInit {
  bsModalRef: BsModalRef;
  rate: number = 4;
  constructor(private modalService: BsModalService) { }

  ngOnInit() {
  }

  addIngredients() {
    const initialState = {
      title: 'ingridient to add to -- item 1--'
    };
    this.bsModalRef = this.modalService.show(IngredientToAddModalComponent,  { initialState, class: 'modal-lg' });
    this.bsModalRef.content.closeBtnName = 'colse';
  }
}
