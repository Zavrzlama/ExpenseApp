import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CitiesEditComponent } from '../cities-edit/cities-edit.component';
import { ICityOverviewModel } from '../Models/ICityOverviewModel';

const ELEMENT_DATA: ICityOverviewModel[] = [
  { id: 1, name: 'Pula', postalCode: "52100" },
  { id: 2, name: 'Zagreb', postalCode: "10000" },
  { id: 3, name: 'Zadar', postalCode: "23232" },
  { id: 4, name: 'Šibenik', postalCode: "23232" },
  { id: 5, name: 'Boron', postalCode: "65656" }
];

@Component({
  selector: 'app-cities-overview',
  templateUrl: './cities-overview.component.html',
  styleUrls: ['./cities-overview.component.scss']
})
export class CitiesOverviewComponent implements OnInit {

  citiesData = ELEMENT_DATA;
  displayedColumns: string[] = ['postalCode', 'cityName' , 'action'];

  constructor(private dialog: MatDialog) { }

  ngOnInit(): void {
  }

  openDialog(id: number): void {

    let city = this.citiesData.find(city => city.id == id);

    const dialogRef = this.dialog.open(CitiesEditComponent,
      {
        width: '400px',
        data: {
          id: city?.id,
          postalCode: city?.postalCode,
          name: city?.name
        }
      });
  }
}