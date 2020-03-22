import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-site-layout',
  templateUrl: './site-layout.component.html',
  styleUrls: ['./site-layout.component.css']
})
export class SiteLayoutComponent implements OnInit {
  isLeftMenu:boolean = false; 
  constructor() { }

  ngOnInit() {
  }
  showMenu($event) {
    this.isLeftMenu = $event;
    console.log('showMenu::', $event);
  } 

}
