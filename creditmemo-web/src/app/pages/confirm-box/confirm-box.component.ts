import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-confirm-box',
  templateUrl: './confirm-box.component.html',
  styleUrls: ['./confirm-box.component.css']
})
export class ConfirmBoxComponent implements OnInit {
  @Input() modalContent;
  @Input() modalHeader;
  @Input() closeButtonName;
  @Input() submitButtonName;
  modalState: boolean = false;
  confirmBoxType: string;

  @Output() modalEvent = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  openConfirmBox(state, type) {
    console.log('openConfirmBox:', state);
    this.modalState = state;
    this.confirmBoxType = type;    
  }

  closePopup() {
    this.modalState = false;
  }

  submitPopup() {
    this.modalState = false;
    this.modalEvent.emit(this.confirmBoxType);
  }

}
