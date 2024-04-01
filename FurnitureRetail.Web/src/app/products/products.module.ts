import { NgModule } from '@angular/core';
import { ProductsListComponent } from './components/products-list/products-list.component';
import { CommonAppModule } from '../common/common.module';
import { ProductsRoutingModule } from './products-routing.module';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { MatRippleModule } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {CdkTableModule} from '@angular/cdk/table';
import { MatTableModule } from '@angular/material/table';

@NgModule({
  declarations: [
    ProductsListComponent
  ],
  imports: [
    CommonAppModule,
    ProductsRoutingModule,
    MatFormFieldModule,
    MatButtonModule,
    MatRippleModule,
    MatSelectModule,
    FormsModule,
    ReactiveFormsModule,
    CdkTableModule,
    MatTableModule
  ]
})
export class ProductsModule { }
