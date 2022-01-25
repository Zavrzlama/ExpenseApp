import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-currencies-edit',
  templateUrl: './currencies-edit.component.html',
  styleUrls: ['./currencies-edit.component.scss']
})
export class CurrenciesEditComponent implements OnInit {

  currencyFormGroup!: FormGroup;
  title: string = '';


  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {

    this.currencyFormGroup = this.formBuilder.group({
      code: ['', Validators.required],
      name: ['', Validators.required]
    }
    )

  }

  saveCurrency(): void {

  }

}
