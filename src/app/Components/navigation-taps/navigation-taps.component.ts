import { Component } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-navigation-taps',
  templateUrl: './navigation-taps.component.html',
  styleUrls: ['./navigation-taps.component.css']
})
export class NavigationTapsComponent {
  constructor(private router: Router) {}

  // Return true if the current URL includes /Students
  isStudentActive(): boolean {
    return this.router.url.includes('/Students');
  }

  // Return true if the current URL includes /Statistics
  isStatisticsActive(): boolean {
    return this.router.url.includes('/Statistics');
  }

}
