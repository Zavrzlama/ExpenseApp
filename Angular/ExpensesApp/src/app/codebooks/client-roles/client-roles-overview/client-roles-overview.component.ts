import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { ClientRolesEditComponent } from '../client-roles-edit/client-roles-edit.component';
import { IClientRoleOvervievModel } from '../Models/IClientRoleOverview';


const data: IClientRoleOvervievModel[] = [{ id: 1, code: 'code1', name: 'Rola1', description: '' }, { id: 2, code: 'code2', name: 'Rola2', description: 'testfdsfs' }]

@Component({
  selector: 'app-client-roles-overview',
  templateUrl: './client-roles-overview.component.html',
  styleUrls: ['./client-roles-overview.component.scss']
})
export class ClientRolesOverviewComponent implements OnInit {

  clientRolesData = data;
  displayedColumns: string[] = ['code', 'name', 'description']

  constructor(private dialog: MatDialog) { }

  ngOnInit(): void {
  }

  openDialog(id: number): void {
    const clientRole = this.clientRolesData.find(x => x.id == id)

    const dialogRef = this.dialog.open(ClientRolesEditComponent, {
      width: '40',
      data: {
        id: clientRole?.id,
        code: clientRole?.code,
        name: clientRole?.name,
        description: clientRole?.description
      }
    })
  }

}
