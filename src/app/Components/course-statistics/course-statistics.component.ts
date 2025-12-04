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
  students: any[] = [];
  courses: any[] = [];
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
        this.courses = courses;

        this.studentService.getStudents().subscribe({
          next: students => {
            this.students = students;

            const totalStudents = this.students.length;

            const series = this.courses.map(c => {
              const count = this.students.filter(s => s.courseIds.includes(c.id)).length;
              return totalStudents > 0 ? Math.round((count / totalStudents) * 100) : 0;
            });

            const labels = this.courses.map(c => c.name);

            this.chartOptions = { ...this.chartOptions, series, labels };
          },
          error: err => {
            this.errorModalService.show("Unable to load students! Check server is running");
          }
        });

      },
      error: err => {
        this.errorModalService.show("Unable to load courses! Check server is running");
      }
    });
  }
}
