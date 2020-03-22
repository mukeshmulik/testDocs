import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-chat-modal',
  templateUrl: './chat-modal.component.html',
  styleUrls: ['./chat-modal.component.css']
})
export class ChatModalComponent implements OnInit {
  openModal: boolean = false;
  constructor() { }

  ngOnInit() {
  }
  openChatModal(state){
    this.openModal = state;
  }
}
