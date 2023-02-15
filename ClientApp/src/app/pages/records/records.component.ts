import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Observable } from 'rxjs';
import { NewRecordComponent } from 'src/app/components/new-record/new-record.component';
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

  constructor(
    private recordsService: RecordsService,
    private dialog: MatDialog
  ) {}

  ngOnInit(): void {
    this.records$ = this.recordsService.getRecords();
  }

  openNewRecordDialog(): void {
    this.dialog.open(NewRecordComponent).beforeClosed().subscribe();
  }
}
