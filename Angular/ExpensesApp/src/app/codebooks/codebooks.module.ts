import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

//Shared
import { SharedModule } from '../shared/shared.module';

//Components
import { ClientsOverviewComponent } from './clients/clients-overview/clients-overview.component';
import { ClientsEditComponent } from './clients/clients-edit/clients-edit.component';
import { ClientRolesEditComponent } from './client-roles/client-roles-edit/client-roles-edit.component';
import { ClientRolesOverviewComponent } from './client-roles/client-roles-overview/client-roles-overview.component';
import { CitiesOverviewComponent } from './cities/cities-overview/cities-overview.component';
import { CitiesEditComponent } from './cities/cities-edit/cities-edit.component';
import { CurrenciesEditComponent } from './currencies/currencies-edit/currencies-edit.component';
import { CurrenciesOverviewComponent } from './currencies/currencies-overview/currencies-overview.component';
import { ExpenseTypesOverviewComponent } from './expense-types/expense-types-overview/expense-types-overview.component';
import { ExpenseTypesEditComponent } from './expense-types/expense-types-edit/expense-types-edit.component';

const routes: Routes = [
  { path: "clientRolesOverview", component: ClientRolesOverviewComponent },
  { path: "citiesOverview", component: CitiesOverviewComponent },
  { path: 'currenciesOverview', component: CurrenciesOverviewComponent },
  { path: 'clientsOverview', component: ClientsOverviewComponent },
  { path: "", component: CitiesOverviewComponent }]


@NgModule({
  declarations: [
    ClientsOverviewComponent,
    ClientsEditComponent,
    ClientRolesEditComponent,
    ClientRolesOverviewComponent,
    CitiesOverviewComponent,
    CitiesEditComponent,
    CurrenciesEditComponent,
    CurrenciesOverviewComponent,
    ExpenseTypesOverviewComponent,
    ExpenseTypesEditComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule.forChild(routes)
  ]

})
export class CodebooksModule { }
