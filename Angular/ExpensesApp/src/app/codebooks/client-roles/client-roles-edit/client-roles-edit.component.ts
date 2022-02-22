import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CodebookForm } from '../../CodebookForm';
import { ClientRoleOverviev } from '../Models/ClientRoleOverview.model';

@Component({
  selector: 'app-client-roles-edit',
  templateUrl: './client-roles-edit.component.html',
  styleUrls: ['./client-roles-edit.component.scss']
})
export class ClientRolesEditComponent extends CodebookForm implements OnInit {

  constructor(
    private formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) private data: ClientRoleOverviev) { super() }

  ngOnInit(): void {
    this.setupTitle(this.data.id)
    this.setupForm();
    this.fillForm();
  }

  fillForm(): void {
    if (this.data.id != null) {
      this.formGroup.patchValue({
        code: this.data.code,
        name: this.data.name,
        description: this.data.description
      })
    }
  }

  setupForm(): void {
    this.formGroup = this.formBuilder.group({
      code: ["", Validators.required],
      name: ["", Validators.required],
      description: [""]
    })
  }

  save(): void {
  }
}
