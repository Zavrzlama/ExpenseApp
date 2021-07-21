import { Component } from '@angular/core';

@Component({
  selector : 'exapp-root',
  template : `<nav class='navbar navbar-expand navbar-light gb-light'>
  <a class='navbar-brand'>{{title}}</a>
  <ul class='nav nav-pills'>
  <li>
  <a class='nav_link' routerLink='/clientRoles'>Client roles</a>
  </li>
  <li>
  <a class='nav_link' [routerLink]="['/clientRole/0/edit']">New Client Role</a>
  </li>
  </ul>
  </nav>
  <div class='container'>
  <router-outlet></router-outlet>
  </div>`
  
})
export class AppComponent{
  title : string = 'ExpensesApp';
}

