import { Component, OnInit, ViewChild } from '@angular/core';
import { ChatModalComponent } from './chat-modal/chat-modal.component';
@Component({
  selector: 'app-track-record',
  templateUrl: './track-record.component.html',
  styleUrls: ['./track-record.component.css']
})
export class TrackRecordComponent implements OnInit {
  @ViewChild(ChatModalComponent, {static: false}) chatModal: ChatModalComponent;

  private trackrecordColumns: any[];
  private trackrecords: any[];
  trackrecordloading: boolean = false;
  private totaltrackrecord: number;
  selectedRowData: any[];
  cols: any[];
  cars: any[] = [
    {
      'vin':1,
      'year':1991,
      'brand':111,
      'color':'red'
    },
    {
      'vin':2,
      'year':1992,
      'brand':222,
      'color':'green'
    },
    {
      'vin':3,
      'year':1993,
      'brand':333,
      'color':'orange'
    }
  ];
  constructor() { }

  ngOnInit() {
    this.selectedRowData = [];
    this.cols = [
        { field: 'vin', header: 'Vin' },
        { field: 'year', header: 'Year' },
        { field: 'brand', header: 'Brand' },
        { field: 'color', header: 'Color' }
    ];


    this.trackrecordColumns = [
      { field: 'Department', header: 'Department'},
      { field: 'CreditReqNo', header: 'Credit Req No'},
      { field: 'CreditType', header: 'Credit Type'},
      { field: 'CreditReason', header: 'Credit Reason'},
      { field: 'InvoiceNo', header: 'Invoice No'},
      { field: 'InvoiceAmount', header: 'Invoice Amount'},
      { field: 'TicketRaisedOn', header: 'Ticket Raised On'},
      // { field: 'SLARemainingDays', header: 'SLA Remaining Days'},
      // { field: 'Status', header: 'xyz'},
      // { field: 'Action', header: 'xyz'}
    ];
    this.trackrecords = [{'Department': 'Engineering Team', 
                         'CreditReqNo': '355632', 
                         'CreditType': 'Defective product',
                         'CreditReason': 'Incorrect carrier used',
                         'InvoiceNo': '1613493',
                         'InvoiceAmount' : '$9,120.40	',
                        'TicketRaisedOn' : '11/01/2019',
                        'SLARemainingDays' : 2,
                        'Status' : 'Open',
                      },
                      {'Department': 'Finance Team', 
                      'CreditReqNo': '6268874', 
                      'CreditType': 'Missing product',
                      'CreditReason': 'Concealed freight damage',
                      'InvoiceNo': '8562612',
                      'InvoiceAmount' : '$5,120.40',
                     'TicketRaisedOn' : '11/01/2019',
                     'SLARemainingDays' : 10,
                     'Status' : 'Assigned',
                   },
                   {'Department': 'Finance Team', 
                      'CreditReqNo': '6268874', 
                      'CreditType': 'Missing product',
                      'CreditReason': 'Concealed freight damage',
                      'InvoiceNo': '8562612',
                      'InvoiceAmount' : '$5,120.40',
                     'TicketRaisedOn' : '11/01/2019',
                     'SLARemainingDays' : 3,
                     'Status' : 'Closed',
                   }
                  
                  ];
  }
  openChatModal(state) {
    this.chatModal.openChatModal(state);
    console.log(this.chatModal.openChatModal(state));
  }
}
