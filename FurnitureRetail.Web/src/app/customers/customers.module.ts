import { NgModule } from '@angular/core';
import { CustomersComponent } from './components/customers/customers.component';
import { CustomersRoutingModule } from './customers-routing.module';
import { CommonAppModule } from '../common/common.module';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatRippleModule } from '@angular/material/core';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatTableModule } from '@angular/material/table';
import { PercentPipe } from '@angular/common';



@NgModule({
  imports: [
    CommonAppModule,
    CustomersRoutingModule,
    MatFormFieldModule,
    MatButtonModule,
    MatRippleModule,
    MatSelectModule,
    FormsModule,
    ReactiveFormsModule,
    MatTableModule,
    PercentPipe
  ],
  declarations: [CustomersComponent],
})
export class CustomersModule {}
