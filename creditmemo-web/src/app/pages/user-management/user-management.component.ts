import { Component, OnInit, ViewChild } from '@angular/core';
import { UserModalComponent } from './user-modal/user-modal.component';
import { ConfirmBoxComponent } from '../confirm-box/confirm-box.component';
import { ApproveModalComponent } from './approve-modal/approve-modal.component'

@Component({
  selector: 'app-user-management',
  templateUrl: './user-management.component.html',
  styleUrls: ['./user-management.component.css']
})
export class UserManagementComponent implements OnInit {
  @ViewChild(ApproveModalComponent, {static: false}) approveModal: ApproveModalComponent;
  @ViewChild(UserModalComponent, {static: false}) userModal: UserModalComponent;
  @ViewChild(ConfirmBoxComponent, {static: false}) child: ConfirmBoxComponent;

  private allRequestColumns: any[];
  private allRequests: any[];
  allRequestloading: boolean = false;
  private totalAllRequests: number;
  private pendingRequestColumns: any[];
  private pendingRequests: any[];
  pendingRequestloading: boolean = false;
  private totalpendingRequests: number;
  modalHeader: string;
  modalContent: string;
  closeButtonName: string;
  submitButtonName: string;

  constructor() { }

  ngOnInit() {
    this.allRequestColumns = [
      { field: 'SrNo', header: 'SrNo' },
      { field: 'GlobalId', header: 'Global ID' },
      { field: 'Username', header: 'Username' },
      { field: 'EmailID', header: 'EmailID' },
      { field: 'ContactNo', header: 'Contact No' },
      { field: 'Department', header: 'Department' },
      { field: 'CreditAmount', header: 'Credit Amount' },
      { field: 'ApprovedDate', header: 'Approved Date' },
      // { field: 'Status', header: 'Status' }
    ];
    this.pendingRequestColumns = [
      { field: 'SrNo', header: 'SrNo' },
      { field: 'GlobalId', header: 'Global ID' },
      { field: 'Username', header: 'Username' },
      { field: 'EmailID', header: 'EmailID' },
      // { field: 'Department', header: 'Department' },
      // { field: 'CreditAmount', header: 'Credit Amount' },
    ];

    this.allRequests = [{'SrNo': 1,
                         'GlobalId': 'Jrathop1', 
                         'Username': 'Priya Rathore', 
                         'EmailID' : 'priya.rathod-ext@jci.com', 
                         'ContactNo': '123456890',
                         'Department' : 'Finance Team',
                         'CreditAmount': '$6000',
                         'ApprovedDate': '	1/10/2019',
                         'Status' : 'Active'
                        },
                        {'SrNo': 2,
                        'GlobalId': 'Jshaiktu', 
                        'Username': 'Tuba Shaikh', 
                        'EmailID' : 'tuba.shaikh-ext@jci.com', 
                        'ContactNo': '123456890',
                        'Department' : 'Sales Team',
                        'CreditAmount': '$600',
                        'ApprovedDate': '	1/10/2019',
                        'Status' : 'Inactive'
                       }];
    this.pendingRequests = [{'SrNo': 1,
                       'GlobalId': 'Jrathop1', 
                       'Username': 'Priya Rathore', 
                       'EmailID' : 'priya.rathod-ext@jci.com', 
                       'Department' : '',
                       'CreditAmount': '',
                      },
                      {'SrNo': 2,
                      'GlobalId': 'Jshaiktu', 
                      'Username': 'Tuba Shaikh', 
                      'EmailID' : 'tuba.shaikh-ext@jci.com', 
                      'Department' : 'Finance Team',
                      'CreditAmount': '$600',
                     }
                    ];
  }
  openUserModal(state) {
    this.userModal.openUserModal(state);
  }
  openApproveModal(state) {
    this.approveModal.openApproveModal(state);
  }
  openConfirmBox(state) {
    this.modalHeader = "Confirmation";
    this.modalContent = 'Are you sure want to delete this data?';
    this.closeButtonName = "Cancel";
    this.submitButtonName = "Yes";
    this.child.openConfirmBox(true, 'deleteUser');
  }
  openRejBox(state) {
    this.modalHeader = "Reject User";
    this.modalContent = 'Are you sure want to reject this user?';
    this.closeButtonName = "Cancel";
    this.submitButtonName = "Yes";
    this.child.openConfirmBox(true, 'deleteUser');
  }
  onConfirm(event) {
    
  }
}
