import { Component, OnInit } from '@angular/core';
import { CoursesService } from '../../services/courses.service';
import { StudentService } from '../../services/student.service';
import {
  ApexNonAxisChartSeries,
  ApexResponsive,
  ApexChart,
  ApexLegend
} from 'ng-apexcharts';
import { ErrorModalService } from '../../services/shared/error-modal.service';
import { Course } from '../../interfaces/Models/Course';
import { Student } from '../../interfaces/Models/Student';


export type PieChartOptions = {
  series: ApexNonAxisChartSeries;
  chart: ApexChart;
  labels: string[];
  responsive: ApexResponsive[];
  legend: ApexLegend;
};

@Component({
  selector: 'app-course-statistics',
  templateUrl: './course-statistics.component.html',
  styleUrls: ['./course-statistics.component.css']
})
export class CourseStatisticsComponent implements OnInit {
  students: Student[] = [];
  courses: Course[] = [];
  public chartOptions: PieChartOptions;

  constructor(
    private courseService: CoursesService,
    private studentService: StudentService,
    private errorModalService: ErrorModalService
  ) {
    this.chartOptions = {
      series: [],
      chart: { type: 'pie', height: 350 },
      labels: [],
      legend: { position: 'bottom' },
      responsive: [
        {
          breakpoint: 480,
          options: {
            chart: { width: 300 },
            legend: { position: 'bottom' }
          }
        }
      ]
    };
  }

  ngOnInit(): void {
    this.loadChartData();
  }

  loadChartData() {
    this.courseService.getAllCourses().subscribe({
      next: courses => {
        this.courses = courses.data;

        this.studentService.getStudents().subscribe({
          next: students => {
            this.students = students.data;
            const totalStudents = this.students.length;

            const series = this.courses.map(c => {
              const count = this.students.filter(s =>
                s.courses.some(course => course.id === c.id)
              ).length;              
              return totalStudents > 0 ? Math.round((count / totalStudents) * 100) : 0;
            });

            const labels = this.courses.map(c => c.name);

            this.chartOptions = { ...this.chartOptions, series, labels };
          },
          error: err => {
            this.errorModalService.show(err.error.message + err.error.errors.join('\n'));
          }
        });

      },
      error: err => {
        this.errorModalService.show(err.error.message + err.error.errors.join('\n'));
      }
    });
  }
}
