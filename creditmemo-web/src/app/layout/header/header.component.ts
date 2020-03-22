import { Component, OnInit, Output, EventEmitter } from '@angular/core'; 

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  showLeftMenu:boolean = false;
    @Output() showmenuEvent = new EventEmitter<boolean>(); 

  constructor() { }

  ngOnInit() {
  }
  toggleMenu(){
    this.showLeftMenu = !this.showLeftMenu;
    this.showmenuEvent.emit(this.showLeftMenu); 
  }
  hideMenu(){
    this.showLeftMenu= true;
  }
}




