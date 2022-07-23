import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { CommonModule } from '@angular/common';
import { RecordsService } from 'src/app/services/records.service';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatCardModule } from '@angular/material/card';
import { RecordsComponent } from 'src/app/pages/records/records.component';
import { MatButtonModule } from '@angular/material/button';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MarketplaceService } from 'src/app/services/marketplace.service';
import { MarketplaceComponent } from 'src/app/pages/marketplace/marketplace.component';
import { MatListModule } from '@angular/material/list';
import { RecordCardomponent } from 'src/app/components/record-card.component';
import { MatTableModule } from '@angular/material/table';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NewItemComponent } from 'src/app/pages/new-item/new-item.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    RecordsComponent,
    MarketplaceComponent,
    RecordCardomponent,
    NewItemComponent,
  ],
  imports: [
    BrowserModule,
    CommonModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'marketplace', component: MarketplaceComponent },
      { path: 'marketplace/new', component: NewItemComponent },
      { path: 'records', component: RecordsComponent },
    ]),

    MatToolbarModule,
    MatButtonModule,
    MatCardModule,
    MatProgressBarModule,
    MatListModule,
    MatTableModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
  ],
  providers: [RecordsService, MarketplaceService],
  bootstrap: [AppComponent],
})
export class AppModule {}
