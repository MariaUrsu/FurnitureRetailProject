import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { CommonAppModule } from './common/common.module';
import { CommonModule } from '@angular/common';
import { EnvironmentModel } from './common/models/environment-model';
import { environmentFactory } from './environments/environment';
import { CustomersModule } from './customers/customers.module';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    CommonAppModule,
    CustomersModule
  ],
  providers: [{
    provide: EnvironmentModel,
    useFactory: environmentFactory
  }],
  bootstrap: [AppComponent],
})
export class AppModule {}
