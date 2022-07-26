import { Record } from './record';

export interface StockItem {
  record: Record;
  condition: number;
  price: number;
}

export interface StockItemRequest {
  recordId: number;
  condition: number;
  price: number;
}

export type StockItems = StockItem[];
