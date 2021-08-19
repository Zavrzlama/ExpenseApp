import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ClientRoleListComponent } from './clientRole-list/clientRole-list.component';
import { ClientRoleEditComponent } from './clientRole-edit/client-role-edit.component';

@NgModule({
  declarations: [
    ClientRoleListComponent,
    ClientRoleEditComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    RouterModule.forChild([
      { path: 'clientRoles', component: ClientRoleListComponent},
      { path: 'clientRole/:id/edit', component: ClientRoleEditComponent }])
  ]
})
export class ClientRoleModule { }