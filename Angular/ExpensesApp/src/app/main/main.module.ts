import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

//Material
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';

//Modules
import { CodebooksModule } from '../codebooks/codebooks.module';
import { SharedModule } from '../shared/shared.module';

//Components
import { SidenavComponent } from './sidenav/sidenav.component';
import { ToolbarComponent } from './toolbar/toolbar.component';


@NgModule({
  declarations: [
    SidenavComponent,
    ToolbarComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    CodebooksModule,
    RouterModule,
    MatSidenavModule,
    MatToolbarModule,
  ],
  exports:[SidenavComponent]
})
export class MainModule { }
