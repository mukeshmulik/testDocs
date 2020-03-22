import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SiteLayoutComponent } from './layout/site-layout/site-layout.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { UserManagementComponent } from './pages/user-management/user-management.component';
import { LoginComponent } from './pages/login/login.component';
import { NewRequestComponent } from './pages/new-request/new-request.component';
import { TrackRecordComponent } from './pages/track-record/track-record.component'
import { CtcReportComponent } from './pages/ctc-report/ctc-report.component';
import { EnggQualityReportComponent } from './pages/engg-quality-report/engg-quality-report.component';
import { ApprovalProcessComponent } from './pages/approval-process/approval-process.component'

const routes: Routes = [
  { path:'', component: LoginComponent },

  {
    path: '',
    component: SiteLayoutComponent,
    children: [
      { path: 'dashboard', component: DashboardComponent },
      { path: 'usermanagement', component: UserManagementComponent },
      { path: 'newrequest', component: NewRequestComponent},
      { path: 'approvalProcess', component: ApprovalProcessComponent},
      { path: 'trackrecord', component: TrackRecordComponent},
      { path: 'ctcreport', component: CtcReportComponent},
      { path: 'enggqualityreport', component: EnggQualityReportComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
