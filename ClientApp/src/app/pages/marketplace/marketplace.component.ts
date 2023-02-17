import {
  ChangeDetectionStrategy,
  ChangeDetectorRef,
  Component,
  OnInit,
} from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
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

  isLoggedIn$: Observable<boolean> = this.auth.isAuthenticated$;
  readonly conditions = Conditions;
  readonly displayedColumns: string[] = [
    'image',
    'name',
    'artist',
    'condition',
    'price',
  ];

  protected readonly placeholderUrl =
    'https://img.redro.pl/fototapety/12-inch-vinyl-record-with-blank-label-isolated-700-231396737.jpg';

  constructor(
    private marketplaceService: MarketplaceService,
    private auth: AuthService
  ) {}

  ngOnInit(): void {
    this.stockItems$ = this.marketplaceService.getStockItems();
  }
}
