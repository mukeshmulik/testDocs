import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-approve-modal',
  templateUrl: './approve-modal.component.html',
  styleUrls: ['./approve-modal.component.css']
})
export class ApproveModalComponent implements OnInit {
  approveModal: boolean = false;
  constructor() { }

  ngOnInit() {
  }
  openApproveModal(state){
    this.approveModal = state;
  }
}
