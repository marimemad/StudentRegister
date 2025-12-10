import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavigationTapsComponent } from './Components/navigation-taps/navigation-taps.component';
import { StudentFormComponent } from './Components/student-form/student-form.component';
import { CourseStatisticsComponent } from './Components/course-statistics/course-statistics.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MatSelectModule } from '@angular/material/select';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgApexchartsModule } from 'ng-apexcharts';
import { LayoutComponent } from './Components/layout/layout.component';
import { ErrorModalComponent } from './Components/shared/error-modal/error-modal.component';

@NgModule({
  declarations: [
    AppComponent,
    NavigationTapsComponent,
    StudentFormComponent,
    CourseStatisticsComponent,
    LayoutComponent,
    ErrorModalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatSelectModule,
    NgApexchartsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
