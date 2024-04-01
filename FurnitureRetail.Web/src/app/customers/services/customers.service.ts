import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../../common/models/user';
import { EnvironmentModel } from '../../common/models/environment-model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CustomerService {
  url: string;

  constructor(private http: HttpClient, private environment: EnvironmentModel) {
    this.url = `${this.environment.api}customers`;
  }

  getCustomers(): Observable<User[]> {
    return this.http.get<User[]>(this.url);
  }
}
