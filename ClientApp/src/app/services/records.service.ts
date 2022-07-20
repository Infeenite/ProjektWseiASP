import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable()
export class RecordsService {
  private readonly baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getRecords() {
    console.log(this.baseUrl);
    return this.http.get('https://localhost:7010/api/records');
  }
}
