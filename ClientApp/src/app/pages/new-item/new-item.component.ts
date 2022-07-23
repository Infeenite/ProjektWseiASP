import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Conditions } from 'src/app/models/conditions';
import { Records } from 'src/app/models/record';
import { RecordsService } from 'src/app/services/records.service';

@Component({
  selector: 'app-new-item',
  templateUrl: './new-item.component.html',
  styleUrls: ['./new-item.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class NewItemComponent implements OnInit {
  constructor(private recordsService: RecordsService) {}
  readonly conditions = Conditions;
  records$!: Observable<Records>;

  ngOnInit() {
    this.records$ = this.recordsService.getRecords();
  }

  submit(): void {}
}
