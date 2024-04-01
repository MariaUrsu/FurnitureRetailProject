import { NgModule } from '@angular/core';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { MatListModule } from '@angular/material/list';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BaseMasterPageComponent } from './components/master-pages/base-master-page/base-master-page.component';
import { SimpleMasterPageComponent } from './components/master-pages/simple-master-page/simple-master-page.component';

@NgModule({
  imports: [
    MatSidenavModule,
    MatButtonModule,
    MatSelectModule,
    MatFormFieldModule,
    MatIconModule,
    MatMenuModule,
    MatListModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  declarations: [
    BaseMasterPageComponent,
    SimpleMasterPageComponent,
  ],
  exports: [

  ],
  providers: []
})
export class CommonAppModule {}
