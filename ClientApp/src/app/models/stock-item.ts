import { Condition } from 'src/app/models/condition.enum';
import { Record } from './record';

export interface StockItem {
  record: Record;
  condition: Condition;
  price: number;
}

export type StockItems = StockItem[];
