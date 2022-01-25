import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ICityOverviewModel } from '../Models/ICityOverviewModel';


@Component({
  selector: 'app-cities-edit',
  templateUrl: './cities-edit.component.html',
  styleUrls: ['./cities-edit.component.scss']
})
export class CitiesEditComponent implements OnInit {

  CityFormGroup!: FormGroup;
  title: string='';

  constructor(private formBuilder: FormBuilder, 
              private dialogRef: MatDialogRef<CitiesEditComponent>, 
              @Inject(MAT_DIALOG_DATA) private data: ICityOverviewModel) { 
              }

  ngOnInit(): void {
    this.CityFormGroup = this.formBuilder.group({
      postalCode: ['', Validators.required],
      cityName: ['', Validators.required]
    });

    this.fillForm();

    if(this.data.id == null){
      this.title = 'New';
    }else{
      this.title = 'Edit';
    }
  }

fillForm():void{
  this.CityFormGroup.patchValue({
    postalCode: this.data.postalCode,
    cityName: this.data.name
  })
}

  saveCity(): void { }

}
