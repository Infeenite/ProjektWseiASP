import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CommonModule } from '@angular/common';
import { RecordsService } from 'src/app/services/records.service';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatCardModule } from '@angular/material/card';
import { RecordsComponent } from 'src/app/records/records.component';
import { MatButtonModule } from '@angular/material/button';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MarketplaceService } from 'src/app/services/marketplace.service';
import { MarketplaceComponent } from 'src/app/marketplace/marketplace.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    RecordsComponent,
    MarketplaceComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    CommonModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'marketplace', component: MarketplaceComponent },
      { path: 'records', component: RecordsComponent },
    ]),

    MatToolbarModule,
    MatButtonModule,
    MatCardModule,
    MatProgressBarModule,
  ],
  providers: [RecordsService, MarketplaceService],
  bootstrap: [AppComponent],
})
export class AppModule {}
