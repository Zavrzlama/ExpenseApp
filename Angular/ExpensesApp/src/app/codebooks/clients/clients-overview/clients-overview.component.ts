import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CodebookOverview } from '../../CodebookOverview';
import { ClientsEditComponent } from '../clients-edit/clients-edit.component';
import { ClientOverview } from '../Models/ClientOverview.model';

const data: ClientOverview[] = [
  { id: 1, code: 'Code1', name: 'Toni', clientRoleId: 1, clientRoleName: 'Role1' },
  { id: 2, code: 'Code2', name: 'Vedran', clientRoleId: 1, clientRoleName: 'Role1' },
  { id: 3, code: 'Code3', name: 'Jolan', clientRoleId: 2, clientRoleName: 'Role2' }
]

@Component({
  selector: 'app-clients-overview',
  templateUrl: './clients-overview.component.html',
  styleUrls: ['./clients-overview.component.scss']
})
export class ClientsOverviewComponent extends CodebookOverview implements OnInit {

  
  constructor(private dialog: MatDialog) { super(); }
    

  ngOnInit(): void {
    this.dataSource = data;
    this.displayedColumns = ["code", "name", "clientRoleName"];
  }

  openDialog(id: number): void {
    const client = this.dataSource.find(client => client.id == id);

    let result = this.dialog.open(ClientsEditComponent, 
      { 
        width: '60', 
        data: client 
      })
  }

}