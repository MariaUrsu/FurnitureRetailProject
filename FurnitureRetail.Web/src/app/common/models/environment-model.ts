import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class EnvironmentModel {
    production: boolean;
    api: string;
  }
