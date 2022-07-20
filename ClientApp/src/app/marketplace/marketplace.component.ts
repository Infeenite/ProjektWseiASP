import {
  ChangeDetectionStrategy,
  ChangeDetectorRef,
  Component,
  OnInit,
} from '@angular/core';
import { StockItems } from 'src/app/models/stock-item';
import { MarketplaceService } from 'src/app/services/marketplace.service';

@Component({
  selector: 'app-marketplace',
  templateUrl: './marketplace.component.html',
  styleUrls: ['./marketplace.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class MarketplaceComponent implements OnInit {
  stockItems: StockItems = [];
  constructor(
    private marketplaceService: MarketplaceService,
    private cd: ChangeDetectorRef
  ) {}

  ngOnInit(): void {
    this.marketplaceService.getStockItems().subscribe((items) => {
      this.stockItems = items;
      this.cd.markForCheck();
    });
  }
}
