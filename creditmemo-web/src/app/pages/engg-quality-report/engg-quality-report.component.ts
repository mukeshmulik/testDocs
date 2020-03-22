import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-engg-quality-report',
  templateUrl: './engg-quality-report.component.html',
  styleUrls: ['./engg-quality-report.component.css']
})
export class EnggQualityReportComponent implements OnInit {

  private enggQualityColumns: any[];
  private enggQuality: any[];
  enggQualityloading: boolean = false;
  private totalenggQuality: number;
  constructor() { }

  ngOnInit() {
    this.enggQualityColumns = [
      { field: 'Department', header: 'Department'},
      { field: 'Control#', header: 'Control#'},
      { field: 'ECCRcase#', header: 'ECCR case#'},
      { field: 'CreditMemo ', header: 'Credit Memo '},
      { field: 'CMAmnt', header: 'CM Amnt'},
      { field: 'YearFiscal', header: 'Year Fiscal'},
      { field: 'FieldServiceDate', header: 'Field Service Date'},
      { field: 'CreditMemoDate', header: 'Credit Memo Date'},
      { field: 'GroupAssigned', header: 'Group Assigned'},
      { field: 'EngSub-Group', header: 'Eng. Sub-Group'},
      { field: 'InitiatingCreditReport', header: 'Initiating Credit Report'},
      { field: 'Plant#', header: 'Plant#'},
      { field: 'Cust Name/Project', header: 'Cust Name / Project'},
      { field: 'ProjectName', header: 'Project Name'},
      { field: 'DateAssigned', header: 'Date Assigned'},
      { field: 'Model#', header: 'Model#'},
      { field: 'REASON(ExactlyfromVIP)', header: 'REASON (Exactly from VIP)'},
      { field: 'FieldServiceSummary', header: 'Field Service Summary'},
      { field: 'EngineeringInvestigation/Why', header: 'Engineering Investigation / Why'},
      { field: 'NextAction', header: 'Next Action'},
      { field: 'CurrentOwner', header: 'Current Owner'},
      { field: 'CorrectiveActions', header: 'Corrective Actions'},
      { field: 'Judgment', header: 'Judgment'},
      { field: 'DateClosed', header: 'Date Closed'},
      
      // { field: 'CreditReqno', header: 'Credit Req no' },
      // { field: 'CreditType', header: 'Credit Type' },
      // { field: 'CreditReason', header: 'Credit Reason' },
      // { field: 'InvoiceNo', header: 'Invoice No' },
      // { field: 'InvoiceAmount', header: 'Invoice Amount' },
      // { field: 'TicketRaisedOn', header: 'Ticket Raised On' },
      // { field: 'SLARemainingDays', header: 'SLA Remaining Days' },
      // { field: 'Action', header: 'Approved PO' }
    ];
    this.enggQuality = [{'Department': 'xyz',
                        'Control#' : 'xyz',
                        'ECCRcase#' : 'xyz',
                        'CreditMemo ' : 'xyz',
                        'CMAmnt' : 'xyz',
                        'YearFiscal' : 'xyz',
                        'FieldServiceDate' : 'xyz',
                        'CreditMemoDate' : 'xyz',
                        'GroupAssigned' : 'xyz',
                        'EngSub-Group' : 'xyz',
                        'InitiatingCreditReport' : 'xyz',
                        'Plant#' : 'xyz',
                        'Cust Name/Project' : 'xyz',
                        'ProjectName' : 'xyz',
                        'DateAssigned' : 'xyz',
                        'Model#' : 'xyz',
                        'REASON(ExactlyfromVIP)' : 'xyz',
                        'FieldServiceSummary' : 'xyz',
                        'EngineeringInvestigation/Why' : 'xyz',
                        'NextAction' : 'xyz',
                        'CurrentOwner' : 'xyz',
                        'CorrectiveActions' : 'xyz',
                        'Judgment' : 'xyz',
                        'DateClosed' : 'xyz'
                       },
                       {'Department': 'xyz11',
                        'Control#' : 'xyz11',
                        'ECCRcase#' : 'xyz11',
                        'CreditMemo ' : 'xyz11',
                        'CMAmnt' : 'xyz11',
                        'YearFiscal' : 'xyz11',
                        'FieldServiceDate' : 'xyz11',
                        'CreditMemoDate' : 'xyz11',
                        'GroupAssigned' : 'xyz11',
                        'EngSub-Group' : 'xyz11',
                        'InitiatingCreditReport' : 'xyz11',
                        'Plant#' : 'xyz11',
                        'Cust Name/Project' : 'xyz11',
                        'ProjectName' : 'xyz11',
                        'DateAssigned' : 'xyz11',
                        'Model#' : 'xyz11',
                        'REASON(ExactlyfromVIP)' : 'xyz11',
                        'FieldServiceSummary' : 'xyz11',
                        'EngineeringInvestigation/Why' : 'xyz11',
                        'NextAction' : 'xyz11',
                        'CurrentOwner' : 'xyz11',
                        'CorrectiveActions' : 'xyz11',
                        'Judgment' : 'xyz11',
                        'DateClosed' : 'xyz11'
                       }
                      ];
  }

}
