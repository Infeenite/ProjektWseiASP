import {
  ChangeDetectionStrategy,
  ChangeDetectorRef,
  Component,
  OnInit,
} from '@angular/core';
import { Observable } from 'rxjs';
import { Conditions } from 'src/app/models/conditions';
import { StockItems } from 'src/app/models/stock-item';
import { MarketplaceService } from 'src/app/services/marketplace.service';

@Component({
  selector: 'app-marketplace',
  templateUrl: './marketplace.component.html',
  styleUrls: ['./marketplace.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class MarketplaceComponent implements OnInit {
  stockItems$!: Observable<StockItems>;
  readonly conditions = Conditions;
  readonly displayedColumns: string[] = [
    'image',
    'name',
    'artist',
    'condition',
    'price',
  ];

  constructor(private marketplaceService: MarketplaceService) {}

  ngOnInit(): void {
    this.stockItems$ = this.marketplaceService.getStockItems();
  }
}
