import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-array',
  templateUrl: './array.component.html',
  styleUrls: ['./array.component.scss']
})
export class ArrayComponent implements OnInit {

  public array1 = [1, 30, 4, 21];

  constructor() { }

  ngOnInit() {
  }

  foo() {
    // let sorted = ;

  }
}
