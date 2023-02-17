import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { Genres } from 'src/app/models/genres';
import { Record } from 'src/app/models/record';

@Component({
  selector: 'app-record-card',
  templateUrl: './record-card.component.html',
  styleUrls: ['./record-card.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class RecordCardomponent {
  readonly genres = Genres;
  protected readonly placeholderUrl =
    'https://img.redro.pl/fototapety/12-inch-vinyl-record-with-blank-label-isolated-700-231396737.jpg';

  @Input()
  record!: Record;
}
