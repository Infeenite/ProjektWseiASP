import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { catchError, EMPTY, Observable } from 'rxjs';
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
    private marketplaceService: MarketplaceService,
    private snackBar: MatSnackBar,
    private router: Router
  ) {}
  readonly conditions = Conditions;
  records$!: Observable<Records>;

  protected serverError: string | null = null;

  protected readonly recordForm = new FormGroup({
    recordId: new FormControl<number | null>(null),
    condition: new FormControl<number | null>(null),
    price: new FormControl<number | null>(null),
  });

  ngOnInit() {
    this.records$ = this.recordsService.getRecords();
  }

  submit(): void {
    if (this.recordForm.valid) {
      this.marketplaceService
        .addStockItem(this.recordForm.value as StockItemRequest)
        .pipe(
          catchError(({ error }) => {
            this.snackBar.open(error.title);
            return EMPTY;
          })
        )
        .subscribe(() => {
          this.snackBar.open('Record has been created!', undefined, {
            duration: 5000,
          });
          this.router.navigate(['/', 'marketplace']);
        });
    } else {
      this.recordForm.markAllAsTouched();
    }
  }
}
