import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ApplicationsRoutingModule } from './applications-routing.module';
import { ApplicationPageComponent } from './pages/application-page/application-page.component';
import { LayoutPageComponent } from './pages/layout-page/layout-page.component';
import { ListPageComponent } from './pages/list-page/list-page.component';
import { NewPageComponent } from './pages/new-page/new-page.component';
import { MaterialModule } from '../material/material.module';

@NgModule({
  declarations: [
    ApplicationPageComponent,
    LayoutPageComponent,
    ListPageComponent,
    NewPageComponent,
  ],
  imports: [CommonModule, ApplicationsRoutingModule, MaterialModule],
})
export class ApplicationsModule {}
