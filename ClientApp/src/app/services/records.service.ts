import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Records, Record } from 'src/app/models/record';
import { Artists } from '../models/artist';

@Injectable()
export class RecordsService {
  private readonly baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getRecords(): Observable<Records> {
    return this.http.get<Records>(this.baseUrl + 'api/records');
  }

  addRecord(record: Record): Observable<Record> {
    return this.http.post<Record>(this.baseUrl + 'api/records', record);
  }

  getArtists(): Observable<Artists> {
    return this.http.get<Artists>(this.baseUrl + 'api/artists');
  }
}
