import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Conditions } from 'src/app/models/conditions';
import { Records } from 'src/app/models/record';
import { StockItemRequest } from 'src/app/models/stock-item';
import { MarketplaceService } from 'src/app/services/marketplace.service';
import { RecordsService } from 'src/app/services/records.service';

@Component({
  selector: 'app-new-item',
  templateUrl: './new-item.component.html',
  styleUrls: ['./new-item.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class NewItemComponent implements OnInit {
  constructor(
    private recordsService: RecordsService,
    private marketplaceService: MarketplaceService
  ) {}
  readonly conditions = Conditions;
  records$!: Observable<Records>;

  request = {
    recordId: null,
    condition: null,
    price: null,
  };

  ngOnInit() {
    this.records$ = this.recordsService.getRecords();
  }

  submit(): void {
    this.marketplaceService
      .addStockItem(this.request as unknown as StockItemRequest)
      .subscribe();
  }
}
