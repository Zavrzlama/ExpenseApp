import { NgModule } from '@angular/core';

import { TestComponent } from './test.component';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav'


@NgModule({
  declarations: [
    TestComponent

  ],
  imports: [MatButtonModule,
            MatSidenavModule,

  ],
  exports: [TestComponent]
})
export class TestModule { }
