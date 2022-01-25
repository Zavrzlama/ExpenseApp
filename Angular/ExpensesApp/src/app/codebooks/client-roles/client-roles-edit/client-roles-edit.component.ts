import { Component, Inject, inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { IClientRoleOvervievModel } from '../Models/IClientRoleOverview';

@Component({
  selector: 'app-client-roles-edit',
  templateUrl: './client-roles-edit.component.html',
  styleUrls: ['./client-roles-edit.component.scss']
})
export class ClientRolesEditComponent implements OnInit {

  title: string = '';
  clientRoleFormGroup!: FormGroup;

  constructor(private formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) private data: IClientRoleOvervievModel) { }

  ngOnInit(): void {
    this.clientRoleFormGroup = this.setupForm();
    this.title = this.setupTitle(this.data);
    this.fillForm(this.data)
  }

  private fillForm(data: IClientRoleOvervievModel): void {
    if (data.id != null) {
      this.clientRoleFormGroup.patchValue({
        code: data.code,
        name: data.name,
        description: data.description
      })
    }
  }

  private setupForm(): FormGroup {
    return this.formBuilder.group({
      code: ['', Validators.required],
      name: ['', Validators.required],
      description: ['']
    })
  }

  private setupTitle(data: IClientRoleOvervievModel): string {
    return data.id == null ? 'New' : 'Edit';
  }

  saveClientRole(): void {
  }
}
