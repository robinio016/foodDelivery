import { Component, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap';

@Component({
  selector: 'app-ingredient-to-add-modal',
  templateUrl: './ingredient-to-add-modal.component.html',
  styleUrls: ['./ingredient-to-add-modal.component.css']
})
export class IngredientToAddModalComponent implements OnInit {
  title: string;
  closeBtnName: string;
  constructor(public bsModalRef: BsModalRef) { }

  ngOnInit() {
  }

}
