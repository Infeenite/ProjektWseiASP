import {
  ChangeDetectionStrategy,
  ChangeDetectorRef,
  Component,
  OnInit,
} from '@angular/core';
import { delay, Observable } from 'rxjs';
import { Genres } from 'src/app/models/genres';
import { Records } from 'src/app/models/record';
import { RecordsService } from 'src/app/services/records.service';

@Component({
  selector: 'app-records',
  templateUrl: './records.component.html',
  styleUrls: ['./records.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class RecordsComponent implements OnInit {
  records$!: Observable<Records>;

  constructor(private recordsService: RecordsService) {}

  ngOnInit(): void {
    // I want to show off the cool loading bar so I delayed it by 1 second
    this.records$ = this.recordsService.getRecords().pipe(delay(1000));
  }
}
