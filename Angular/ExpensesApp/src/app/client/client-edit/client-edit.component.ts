import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ClientRolesService } from 'app/clientRole/clientRoles.service';
import { IClientRole } from 'app/clientRole/Models/IClientRole.component';

@Component({
  selector: 'exapp-client-edit',
  templateUrl: './client-edit.component.html',
  styleUrls: ['./client-edit.component.css']
})
export class ClientEditComponent implements OnInit {

  clientForm!: FormGroup;
  clientRoles: IClientRole[] = [];
  errorMessage: string = '';
  errorClientDescription:string='';
  errorClientName:string='';

  constructor(
    private fb: FormBuilder,
    private clientRoleService: ClientRolesService) { }

  ngOnInit(): void {
    //Form builder
    this.clientForm = this.fb.group({
      clientName: ['', Validators.required],
      clientDescription: [''],
      clientRoleId: [0,Validators.required]
    })

    //ClientRoleService
    this.clientRoleService.getClientRoles().subscribe(
      {
        next: clientRoles => this.clientRoles = clientRoles,
        error: err => this.errorMessage = err
      }
    )

    const clientRoleId = this.clientForm.get("clientRoleId");
    clientRoleId?.valueChanges.subscribe(()=> console.log(clientRoleId.value))
  }

  saveClient():void{

  }
}
