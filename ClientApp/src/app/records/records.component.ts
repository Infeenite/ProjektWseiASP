import {
  ChangeDetectionStrategy,
  ChangeDetectorRef,
  Component,
  OnInit,
} from '@angular/core';
import { delay } from 'rxjs';
import { Records } from 'src/app/models/record';
import { RecordsService } from 'src/app/services/records.service';

@Component({
  selector: 'app-records',
  templateUrl: './records.component.html',
  styleUrls: ['./records.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class RecordsComponent implements OnInit {
  isLoading = false;
  records: Records = [];

  constructor(
    private recordsService: RecordsService,
    private cd: ChangeDetectorRef
  ) {}

  ngOnInit(): void {
    this.isLoading = true;

    // I want to show off the cool loading bar so I delayed it by 1 second
    this.recordsService
      .getRecords()
      .pipe(delay(1000))
      .subscribe((records) => {
        this.isLoading = false;
        this.records = records;
        this.cd.markForCheck();
      });
  }
}
