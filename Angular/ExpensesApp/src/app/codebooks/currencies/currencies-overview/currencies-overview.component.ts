import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CodebookOverview } from '../../CodebookOverview';
import { CurrenciesEditComponent } from '../currencies-edit/currencies-edit.component';
import { CurrencyOverview } from '../Models/CurrencyOverview.model';

const data: CurrencyOverview[] = [{ id: 1, code: "code1", name: "EUR" }, { id: 2, code: "code2", name: "USD" }, { id: 2, code: "KN", name: "KN" }]

@Component({
  selector: 'app-currencies-overview',
  templateUrl: './currencies-overview.component.html',
  styleUrls: ['./currencies-overview.component.scss']
})
export class CurrenciesOverviewComponent extends CodebookOverview implements OnInit {
  
  constructor(private dialog: MatDialog) { super(); }

  ngOnInit(): void {
    this.dataSource = data;
    this.displayedColumns = ["code", "name", "action"];  
  }

  openDialog(id: number): void {
    let currency = this.dataSource.find(currency => currency.id == id);

    const dialogRef = this.dialog.open(CurrenciesEditComponent, {
      width: '400px', 
      data: {
        id: currency?.id,
        code: currency?.code,
        name: currency?.name
      }
    })
  }
}
