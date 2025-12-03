import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CoursesService } from '../../services/courses.service';
import { StudentService } from '../../services/student.service';
import { courseLimitValidator } from './CustomValidator';

@Component({
  selector: 'app-student-form',
  templateUrl: './student-form.component.html',
  styleUrls: ['./student-form.component.css']
})
export class StudentFormComponent implements OnInit {

  studentForm: FormGroup;
  courses: any[] = [];

  constructor(
    private fb: FormBuilder,
    private courseService: CoursesService,
    private studentService: StudentService
  ) {
    this.studentForm = this.fb.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      address: [''],
      dateOfBirth: ['', Validators.required],
      courseIds: [[], courseLimitValidator]
    });
  }

  ngOnInit(): void {
    this.courseService.getAllCourses().subscribe(data => {
      this.courses = data;
    });
  }

  onSubmit() {
    if (this.studentForm.valid) {
      this.studentService.addStudent(this.studentForm.value).subscribe({
        next: (response) => {
          console.log("Student saved:", response);
          alert("Student saved successfully!");
        },
        error: (err) => {
          console.error("Error saving student:", err);
        }
      });
    } else {
      alert("Form is invalid!");
    }
  }
}
