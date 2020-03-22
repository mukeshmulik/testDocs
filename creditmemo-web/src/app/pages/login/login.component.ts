import { Component, OnInit, Inject, Renderer2} from '@angular/core';
import { DOCUMENT } from '@angular/common';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  showVersion:boolean = false;
  hideLoginForm: boolean = true;
  constructor(
    @Inject(DOCUMENT) private document: Document,
    private renderer: Renderer2,
  ) { }

  ngOnInit() {
    this.renderer.addClass(this.document.body, 'login');
  }
  operateSideBar() {    
    this.showVersion = !this.showVersion;
  }
  toggleDismiss() {
    this.showVersion = !this.showVersion;
  }
  toggleLogin() {
    console.log('hideLoginForm::', this.hideLoginForm);
    this.hideLoginForm = !this.hideLoginForm;
    console.log('hideLoginForm11::', this.hideLoginForm);
  }
  ngOnDestroy(): void {
    this.renderer.removeClass(this.document.body, 'login');
  }

}
