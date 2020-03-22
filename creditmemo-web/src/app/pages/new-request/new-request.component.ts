import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-new-request',
  templateUrl: './new-request.component.html',
  styleUrls: ['./new-request.component.css']
})
export class NewRequestComponent implements OnInit {
  private newRequestColumns: any[];
  private newRequests: any[];
  newRequestloading: boolean = false;
  private totalNewRequests: number;
  constructor() { }

  ngOnInit() {
    this.newRequestColumns = [
      { field: 'CreditReqno', header: 'Credit Req no' },
      { field: 'CreditType', header: 'Credit Type' },
      { field: 'CreditReason', header: 'Credit Reason' },
      { field: 'InvoiceNo', header: 'Invoice No' },
      { field: 'InvoiceAmount', header: 'Invoice Amount' },
      { field: 'TicketRaisedOn', header: 'Ticket Raised On' },
      // { field: 'SLARemainingDays', header: 'SLA Remaining Days' },
      // { field: 'Action', header: 'Approved PO' }
    ];
    this.newRequests = [{'CreditReqno': '35565', 
                         'CreditType': 'Missing product', 
                         'CreditReason': 'Incorrect carrier used',
                         'InvoiceNo': '1613493',
                         'InvoiceAmount': '$9,120.40',
                         'TicketRaisedOn' : '11/01/2019',
                        'SLARemainingDays' : 2},
                        {'CreditReqno': '35533', 
                        'CreditType': 'Missing product', 
                        'CreditReason': 'Incorrect carrier used',
                        'InvoiceNo': '1613493',
                        'InvoiceAmount': '$9,120.40',
                        'TicketRaisedOn' : '11/01/2019',
                       'SLARemainingDays' : 4}];
  }

}
