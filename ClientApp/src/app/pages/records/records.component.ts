import {
  ChangeDetectionStrategy,
  ChangeDetectorRef,
  Component,
  OnInit,
} from '@angular/core';
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
  protected records!: Records;

  constructor(
    private recordsService: RecordsService,
    private dialog: MatDialog,
    private changeDet: ChangeDetectorRef
  ) {}

  ngOnInit(): void {
    this.reload();
  }

  openNewRecordDialog(): void {
    this.dialog
      .open(NewRecordComponent)
      .beforeClosed()
      .subscribe(() => this.reload());
  }

  private reload(): void {
    this.recordsService.getRecords().subscribe((records) => {
      this.records = records;
      console.log(this.records);
      this.changeDet.markForCheck();
    });
  }
}
