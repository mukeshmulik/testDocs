import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { SiteLayoutComponent } from './layout/site-layout/site-layout.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { LoginComponent } from './pages/login/login.component';
import { UserManagementComponent } from './pages/user-management/user-management.component';
import { TableModule } from 'primeng/table';
import { UserModalComponent } from './pages/user-management/user-modal/user-modal.component';
import { ConfirmBoxComponent } from './pages/confirm-box/confirm-box.component';
import { NewRequestComponent } from './pages/new-request/new-request.component';
import { TrackRecordComponent } from './pages/track-record/track-record.component';
import { ChatModalComponent } from './pages/track-record/chat-modal/chat-modal.component';
import { EnggQualityReportComponent } from './pages/engg-quality-report/engg-quality-report.component';
import { CtcReportComponent } from './pages/ctc-report/ctc-report.component';
import { ApproveModalComponent } from './pages/user-management/approve-modal/approve-modal.component';
import { ApprovalProcessComponent } from './pages/approval-process/approval-process.component';

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    HeaderComponent,
    FooterComponent,
    SiteLayoutComponent,
    DashboardComponent,
    LoginComponent,
    UserManagementComponent,
    UserModalComponent,
    ConfirmBoxComponent,
    NewRequestComponent,
    TrackRecordComponent,
    ChatModalComponent,
    EnggQualityReportComponent,
    CtcReportComponent,
    ApproveModalComponent,
    ApprovalProcessComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    TableModule,
    FormsModule      
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
