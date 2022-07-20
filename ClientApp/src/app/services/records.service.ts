import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Records } from 'src/app/models/record';

@Injectable()
export class RecordsService {
  private readonly baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getRecords(): Observable<Records> {
    return this.http.get<Records>(this.baseUrl + 'api/records');
  }
}
