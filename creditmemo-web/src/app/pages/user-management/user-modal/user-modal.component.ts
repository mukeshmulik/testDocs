import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-modal',
  templateUrl: './user-modal.component.html',
  styleUrls: ['./user-modal.component.css']
})
export class UserModalComponent implements OnInit {
  openModal: boolean = false;
  comment: boolean = false;
  constructor() { }

  ngOnInit() {
  }
  openUserModal(state) {
    this.openModal = state;
  }
  showComment(event){
    // console.log("data", event.target.value);
    if(event.target.value == 'inactive'){
        this.comment = true;
    }else{
      this.comment = false;
    }
  }
}
