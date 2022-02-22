import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ClientRoleOverviev } from '../../client-roles/Models/ClientRoleOverview.model';
import { CodebookForm } from '../../CodebookForm';

import { ClientOverview } from '../Models/ClientOverview.model';

const data1: ClientRoleOverviev[] = [{ id: 1, code: "code1", name: "Rola1", description: "test" }, { id: 2, code: "code2", name: "Rola2", description: "test fdfdfd" }]

@Component({
  selector: 'app-clients-edit',
  templateUrl: './clients-edit.component.html',
  styleUrls: ['./clients-edit.component.scss']
})
export class ClientsEditComponent extends CodebookForm implements OnInit {

  clientRoles = data1;

  constructor(
    private formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) private data: ClientOverview) { super() }

  ngOnInit(): void {
    //this.setupTitle(this.data.id);
    this.setupForm();
    this.fillForm();
  }

  setupForm(): void {
    this.formGroup = this.formBuilder.group({
      code: ["", Validators.required],
      name: ["", Validators.required],
      description: [""],
      clientRoleId: [0, Validators.required]
    })
  }

  fillForm(): void {
    if (this.data != undefined) {
      this.formGroup.patchValue({
        code: this.data.code,
        name: this.data.name,
        clientRoleID: this.data.clientRoleId
      })
    }
  }

  save(): void {

  }
}
