import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {StudentFormComponent} from "./Components/student-form/student-form.component"
import {CourseStatisticsComponent} from "./Components/course-statistics/course-statistics.component"
import {NavigationTapsComponent} from "./Components/navigation-taps/navigation-taps.component"
import {LayoutComponent} from "./Components/layout/layout.component"
// const routes: Routes = [
//   { path: '', component: NavigationTapsComponent },
//   { path: 'Students', component: StudentFormComponent },
//   { path: 'Statistics', component: CourseStatisticsComponent },
// ];

const routes: Routes = [
  { path: '', component: NavigationTapsComponent },   // only navbar

  {
    path: '',
    component: LayoutComponent,
    children: [
      { path: 'Students', component: StudentFormComponent },
      { path: 'Statistics', component: CourseStatisticsComponent },
    ]
  }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
