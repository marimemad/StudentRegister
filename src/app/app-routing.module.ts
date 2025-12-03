import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {StudentFormComponent} from "./Components/student-form/student-form.component"
import {CourseStatisticsComponent} from "./Components/course-statistics/course-statistics.component"

const routes: Routes = [
  { path: '', component: StudentFormComponent },
  { path: 'Students', component: StudentFormComponent },
  { path: 'Statistics', component: CourseStatisticsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
