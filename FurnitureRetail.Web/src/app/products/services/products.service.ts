import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { EnvironmentModel } from '../../common/models/environment-model';
import { Product } from 'src/app/common/models/product';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class productsService {
  url: string;

  constructor(private http: HttpClient, private environment: EnvironmentModel) {
    this.url = `${this.environment.api}products`;
  }

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.url);

  }
}
