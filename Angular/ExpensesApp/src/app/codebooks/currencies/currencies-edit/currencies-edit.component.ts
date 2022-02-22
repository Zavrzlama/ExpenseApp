import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CodebookForm } from '../../CodebookForm';
import { CurrencyOverview } from '../Models/CurrencyOverview.model';

@Component({
  selector: 'app-currencies-edit',
  templateUrl: './currencies-edit.component.html',
  styleUrls: ['./currencies-edit.component.scss']
})
export class CurrenciesEditComponent extends CodebookForm implements OnInit {

  constructor(
    private formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) private data: CurrencyOverview) { super(); }

  ngOnInit(): void {
    this.setupTitle(this.data.id);
    this.setupForm();
    this.fillForm();
  }

  setupForm(): void {
    this.formGroup = this.formBuilder.group({
      code: ["", Validators.required],
      name: ["", Validators.required]
    });
  }

  fillForm(): void {
    this.formGroup.patchValue({
      code: this.data.code,
      name: this.data.name
    })
  }

  save(): void {

  }

}
