import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CodebookOverview } from '../../CodebookOverview';
import { ClientRolesEditComponent } from '../client-roles-edit/client-roles-edit.component';
import { ClientRoleOverviev } from '../Models/ClientRoleOverview.model';


const data: ClientRoleOverviev[] = [
  { id: 1, code: "code1", name: 'Rola1' }, 
  { id: 2, code: "code2", name: 'Rola2', description: 'testfdsfs' }]

@Component({
  selector: 'app-client-roles-overview',
  templateUrl: './client-roles-overview.component.html',
  styleUrls: ['./client-roles-overview.component.scss']
})
export class ClientRolesOverviewComponent extends CodebookOverview implements OnInit {

  constructor(private dialog:MatDialog) { super(); }

  ngOnInit(): void {
    this.dataSource = data;
    this.displayedColumns = ["code", "name", "description", "action"];
  }

  openDialog(id: number): void {
    
    const clientRole = this.dataSource.find(x => x.id == id)

    const dialogRef = this.dialog.open(ClientRolesEditComponent, {
      width: "50",
      data: clientRole
    })
  }

}
