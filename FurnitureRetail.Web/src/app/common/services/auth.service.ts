import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/user';
import { EnvironmentModel } from '../models/environment-model';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  loginUrl;

  constructor(private http: HttpClient, private environment: EnvironmentModel) {
    this.loginUrl = `${this.environment.api}accounts/authentication`;
  }

  login(userCredentials: User): Promise<any> {
    return new Promise<void>(() => {
      this.http.post(`${this.loginUrl}/spa`, userCredentials).toPromise();
    });
  }
}
