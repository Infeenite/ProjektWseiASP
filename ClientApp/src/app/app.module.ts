import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { CommonModule } from '@angular/common';
import { RecordsService } from 'src/app/services/records.service';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatCardModule } from '@angular/material/card';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { RecordsComponent } from 'src/app/pages/records/records.component';
import { MatButtonModule } from '@angular/material/button';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MarketplaceService } from 'src/app/services/marketplace.service';
import { MarketplaceComponent } from 'src/app/pages/marketplace/marketplace.component';
import { MatListModule } from '@angular/material/list';
import { RecordCardomponent } from 'src/app/components/record-card/record-card.component';
import { MatTableModule } from '@angular/material/table';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NewItemComponent } from 'src/app/pages/new-item/new-item.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { NewRecordComponent } from './components/new-record/new-record.component';
import { AuthHttpInterceptor, AuthModule } from '@auth0/auth0-angular';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    RecordsComponent,
    MarketplaceComponent,
    RecordCardomponent,
    NewItemComponent,
    NewRecordComponent,
  ],
  imports: [
    BrowserModule,
    CommonModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'marketplace', component: MarketplaceComponent },
      { path: 'marketplace/new', component: NewItemComponent },
      { path: 'records', component: RecordsComponent },
    ]),

    // Import the module into the application, with configuration
    AuthModule.forRoot({
      // The domain and clientId were configured in the previous chapter
      domain: 'dev-ii87cwbmy7f2mchv.us.auth0.com',
      clientId: 'uU8ibeK1qfte5qkA8IYCif2CV38oL239',

      authorizationParams: {
        // Request this audience at user authentication time
        audience: 'https://dev-ii87cwbmy7f2mchv.us.auth0.com/api/v2/',
        redirect_uri: window.location.origin,
      },

      // Specify configuration for the interceptor
      httpInterceptor: {
        allowedList: [
          {
            // Match any request that starts 'https://dev-ii87cwbmy7f2mchv.us.auth0.com/api/v2/' (note the asterisk)
            uri: 'https://localhost:7010/api/records',
            tokenOptions: {
              authorizationParams: {
                // The attached token should target this audience
                audience: 'https://api.wsei-asp-project.com',
                scope: 'read:records',
              },
            },
          },
        ],
      },
    }),
    MatToolbarModule,
    MatButtonModule,
    MatCardModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatListModule,
    MatTableModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatSnackBarModule,
    MatDialogModule,
  ],
  providers: [
    RecordsService,
    MarketplaceService,
    { provide: HTTP_INTERCEPTORS, useClass: AuthHttpInterceptor, multi: true },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
