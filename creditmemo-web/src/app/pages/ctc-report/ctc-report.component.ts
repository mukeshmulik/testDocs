import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ctc-report',
  templateUrl: './ctc-report.component.html',
  styleUrls: ['./ctc-report.component.css']
})
export class CtcReportComponent implements OnInit {
  private allreqColumns: any[];
  private allreq: any[];
  allreqloading: boolean = false;
  private totalallreq: number;

  private pendingreqColumns: any[];
  private pendingreq: any[];
  pendingreqloading: boolean = false;
  private totalpendingreq: number;

  constructor() { }

  ngOnInit() {
    this.allreqColumns = [
      { field: 'Months', header: 'Months'}, 
      { field: 'TotalCreditMemos', header: 'Total Credit Memos'}, 
      { field: 'Percentage', header: 'Percentage'}, 
      { field: 'TotalNon-MfgCM', header: 'Total Non-Mfg CM'}, 
      { field: 'TotalMfgCM', header: 'Total Mfg CM'}, 
      { field: 'InvoiceDollars', header: 'Invoice Dollars'}, 
      { field: 'CreditMemoDollars', header: 'Credit Memo Dollars'}, 
      { field: 'Difference', header: 'Difference'}, 
      { field: 'ReplacementInvoiceDollars', header: 'Replacement Invoice Dollars'}, 
      { field: 'ActualCosttoCompany', header: 'Actual Cost to Company'}, 
      { field: 'Avg.DaysShipDatetoCompliant', header: 'Avg. Days Ship Date to Compliant'}, 
      { field: 'Avg.DaysRGAOpenClosed', header: 'Avg. Days RGA Open Closed'}, 
      { field: 'Avg.DaysComplianttoCMIssued', header: 'Avg. Days Compliant to CM Issued'}, 
    ];
    this.allreq = [{'Months' : 'xyz',
                        'TotalCreditMemos' : 'xyz',
                        'Percentage' : 'xyz',
                        'TotalNon-MfgCM' : 'xyz',
                        'TotalMfgCM' : 'xyz',
                        'InvoiceDollars' : 'xyz',
                        'CreditMemoDollars' : 'xyz',
                        'Difference' : 'xyz',
                        'ReplacementInvoiceDollars' : 'xyz',
                        'ActualCosttoCompany' : 'xyz',
                        'Avg.DaysShipDatetoCompliant' : 'xyz',
                        'Avg.DaysRGAOpenClosed' : 'xyz',
                        'Avg.DaysComplianttoCMIssued' : 'xyz',
                        },
                        {'Months' : 'xyz1',
                        'TotalCreditMemos' : 'xyz1',
                        'Percentage' : 'xyz1',
                        'TotalNon-MfgCM' : 'xyz1',
                        'TotalMfgCM' : 'xyz1',
                        'InvoiceDollars' : 'xyz1',
                        'CreditMemoDollars' : 'xyz1',
                        'Difference' : 'xyz1',
                        'ReplacementInvoiceDollars' : 'xyz1',
                        'ActualCosttoCompany' : 'xyz1',
                        'Avg.DaysShipDatetoCompliant' : 'xyz1',
                        'Avg.DaysRGAOpenClosed' : 'xyz1',
                        'Avg.DaysComplianttoCMIssued' : 'xyz1',
                        }
     
                      ];
    this.pendingreqColumns = [
      { field: 'CMControlNo', header: 'CM Control No'},
      { field: 'Plant', header: 'Plant'},
      { field: 'DepartmentAssignedto', header: 'Department Assigned to'},
      { field: 'DepartmentReassignedto', header: 'Department Reassigned to'},
      { field: 'Product/Issue', header: 'Product/Issue'},
      { field: 'NonManufacturingIssues', header: 'Non Manufacturing Issues'},
      { field: 'CreditMemoWrittenOriginalInvoice', header: 'Credit Memo Written Original Invoice'},
      { field: 'OriginalInvoiceNo', header: 'Original Invoice No'},
      { field: 'InvoiceAmount', header: 'Invoice Amount'},
      { field: 'CreditMemoAmount', header: 'Credit Memo Amount'},
      { field: 'DifferenceInvoiceCreditMemo', header: 'Difference Invoice Credit Memo'},
      { field: '%CreditMemovs.Invoice', header: '% Credit Memo vs. Invoice'},
      { field: 'ReplacementControlNo', header: 'Replacement Control No'},
      { field: 'ReplacementInvoiceAmount', header: 'Replacement Invoice Amount'},
      { field: 'RestockingFeeY/N', header: 'Restocking Fee Y/N'},
      { field: 'OriginalCreditMemoAmount', header: 'Original Credit Memo Amount'},
      { field: 'RestockingFeeCharge', header: 'Restocking Fee Charge'},
      { field: 'ActualCompanyCost', header: 'Actual Company Cost'},
      { field: 'OriginalShipDate', header: 'Original Ship Date'},
      { field: 'CustomerCompliantDate', header: 'Customer Compliant Date'},
      { field: 'RGAOpenDate', header: 'RGA Open Date'},
      { field: 'RGAClosedDate', header: 'RGA Closed Date'},
      { field: 'CMIssueDate', header: 'CM Issue Date'},
      { field: 'DaysShipDateCompliant', header: 'Days Ship Date Compliant'},
      { field: 'DaysRGAOpenClosed', header: 'Days RGA Open Closed'},
      { field: 'DaysCompliantCMIssued', header: 'Days Compliant CM Issued'}
    ];
    this.pendingreq = [{'CMControlNo' : 'xyz',
                        'Plant' : 'xyz',
                        'DepartmentAssignedto' : 'xyz',
                        'DepartmentReassignedto' : 'xyz',
                        'Product/Issue' : 'xyz',
                        'NonManufacturingIssues' : 'xyz',
                        'CreditMemoWrittenOriginalInvoice' : 'xyz',
                        'OriginalInvoiceNo' : 'xyz',
                        'InvoiceAmount' : 'xyz',
                        'CreditMemoAmount' : 'xyz',
                        'DifferenceInvoiceCreditMemo' : 'xyz',
                        '%CreditMemovs.Invoice' : 'xyz',
                        'ReplacementControlNo' : 'xyz',
                        'ReplacementInvoiceAmount' : 'xyz',
                        'RestockingFeeY/N' : 'xyz',
                        'OriginalCreditMemoAmount' : 'xyz',
                        'RestockingFeeCharge' : 'xyz',
                        'ActualCompanyCost' : 'xyz',
                        'OriginalShipDate' : 'xyz',
                        'CustomerCompliantDate' : 'xyz',
                        'RGAOpenDate' : 'xyz',
                        'RGAClosedDate' : 'xyz',
                        'CMIssueDate' : 'xyz',
                        'DaysShipDateCompliant' : 'xyz',
                        'DaysRGAOpenClosed' : 'xyz',
                        'DaysCompliantCMIssued' : 'xyz',
                      },
                      {'CMControlNo' : 'xyz',
                        'Plant' : 'xyz',
                        'DepartmentAssignedto' : 'xyz',
                        'DepartmentReassignedto' : 'xyz',
                        'Product/Issue' : 'xyz',
                        'NonManufacturingIssues' : 'xyz',
                        'CreditMemoWrittenOriginalInvoice' : 'xyz',
                        'OriginalInvoiceNo' : 'xyz',
                        'InvoiceAmount' : 'xyz',
                        'CreditMemoAmount' : 'xyz',
                        'DifferenceInvoiceCreditMemo' : 'xyz',
                        '%CreditMemovs.Invoice' : 'xyz',
                        'ReplacementControlNo' : 'xyz',
                        'ReplacementInvoiceAmount' : 'xyz',
                        'RestockingFeeY/N' : 'xyz',
                        'OriginalCreditMemoAmount' : 'xyz',
                        'RestockingFeeCharge' : 'xyz',
                        'ActualCompanyCost' : 'xyz',
                        'OriginalShipDate' : 'xyz',
                        'CustomerCompliantDate' : 'xyz',
                        'RGAOpenDate' : 'xyz',
                        'RGAClosedDate' : 'xyz',
                        'CMIssueDate' : 'xyz',
                        'DaysShipDateCompliant' : 'xyz',
                        'DaysRGAOpenClosed' : 'xyz',
                        'DaysCompliantCMIssued' : 'xyz',
                      }
                      ];
                  }
  }

 


