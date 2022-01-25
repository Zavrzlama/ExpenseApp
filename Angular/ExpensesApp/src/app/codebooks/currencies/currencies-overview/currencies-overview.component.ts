import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CurrenciesEditComponent } from '../currencies-edit/currencies-edit.component';
import { ICurrencyOverviewModel } from '../Models/ICurrencyOverviewModel';

const data: ICurrencyOverviewModel[] = [{ id: 1, code: "code1", name: "EUR" }, { id: 2, code: "code2", name: "USD" }, { id: 2, code: "KN", name: "KN" }]

@Component({
  selector: 'app-currencies-overview',
  templateUrl: './currencies-overview.component.html',
  styleUrls: ['./currencies-overview.component.scss']
})
export class CurrenciesOverviewComponent implements OnInit {
  currenciesData = data;
  displayedColumns = ['code', 'name', 'action'];
  constructor(private dialog: MatDialog) { }

  ngOnInit(): void {
  }

  openDialog(id: number): void {


    const dialogRef = this.dialog.open(CurrenciesEditComponent, {
      width: '400px', data: {
        id: 0,
        code: 'Test',
        name: 'Test1232'
      }
    })
  }
}
