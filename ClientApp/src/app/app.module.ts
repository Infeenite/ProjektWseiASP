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

@NgModule({
  declarations: [AppComponent, HomeComponent],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    CommonModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
    ]),

    MatToolbarModule,
    MatCardModule,
  ],
  providers: [RecordsService],
  bootstrap: [AppComponent],
})
export class AppModule {}
