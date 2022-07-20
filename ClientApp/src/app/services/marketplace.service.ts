import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StockItems } from 'src/app/models/stock-item';

@Injectable()
export class MarketplaceService {
  private readonly baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getStockItems(): Observable<StockItems> {
    return this.http.get<StockItems>(this.baseUrl + 'api/stocks');
  }
}
