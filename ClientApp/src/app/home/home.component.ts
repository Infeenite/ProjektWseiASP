import { Component, OnInit } from '@angular/core';
import { RecordsService } from 'src/app/services/records.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  records: any;

  constructor(private recordsService: RecordsService) {}

  ngOnInit(): void {
    this.recordsService.getRecords().subscribe((res) => (this.records = res));
  }
}
