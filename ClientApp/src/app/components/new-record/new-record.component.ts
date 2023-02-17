import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { catchError, EMPTY, Observable } from 'rxjs';
import { Artists } from 'src/app/models/artist';
import { Genres } from 'src/app/models/genres';
import { Record } from 'src/app/models/record';
import { RecordsService } from 'src/app/services/records.service';

@Component({
  selector: 'app-new-record',
  templateUrl: './new-record.component.html',
  styleUrls: ['./new-record.component.scss'],
})
export class NewRecordComponent {
  constructor(
    private recordsService: RecordsService,
    private snackBar: MatSnackBar,
    private dialogRef: MatDialogRef<any>
  ) {}

  protected readonly genres = Genres;

  protected readonly recordForm = new FormGroup({
    artistId: new FormControl<number | null>(null),
    serialNumber: new FormControl<string | null>(null),
    name: new FormControl<string | null>(null),
    releaseYear: new FormControl<string | null>(null),
    genreId: new FormControl<number | null>(null),
  });

  artists$: Observable<Artists> = this.recordsService.getArtists();

  submit(): void {
    if (this.recordForm.valid) {
      this.recordsService
        .addRecord(this.recordForm.value as Record)
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
          this.dialogRef.close();
        });
    } else {
      this.recordForm.markAllAsTouched();
    }
  }
}
