import { Component } from '@angular/core';
import { AuthService, User } from '@auth0/auth0-angular';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  constructor(private auth: AuthService) {}

  isAuthenticated$ = this.auth.isAuthenticated$;
  user$: Observable<User | null | undefined> = this.auth.user$;

  protected login(): void {
    this.auth.loginWithPopup();
  }

  protected logout(): void {
    this.auth.logout();
  }
}
