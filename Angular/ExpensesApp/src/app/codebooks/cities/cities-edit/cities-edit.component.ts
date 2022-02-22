import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CodebookForm } from '../../CodebookForm';
import { CityOverview } from '../Models/CityOverview.model';

@Component({
  selector: 'app-cities-edit',
  templateUrl: './cities-edit.component.html',
  styleUrls: ['./cities-edit.component.scss']
})
export class CitiesEditComponent extends CodebookForm implements OnInit {

  constructor(
    private formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) private data: CityOverview) { super(); }

  ngOnInit(): void {
    this.setupTitle(this.data.id);
    this.setupForm();
    this.fillForm();
  }

  setupForm(): void {
    this.formGroup = this.formBuilder.group({
      postalCode: ["", Validators.required],
      cityName: ["", Validators.required]
    });
  }

  fillForm(): void {
    this.formGroup.patchValue({
      postalCode: this.data.postalCode,
      cityName: this.data.name
    })
  }

  save(): void { }

}
