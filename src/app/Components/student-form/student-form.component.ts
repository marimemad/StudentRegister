import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CoursesService } from '../../services/courses.service';
import { StudentService } from '../../services/student.service';
import { courseLimitValidator } from './CustomValidator';
import { ErrorModalService } from '../../services/shared/error-modal.service';


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
    private studentService: StudentService,
    private errorModalService: ErrorModalService
  ) {
    this.studentForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(3)]],
      email: ['', [Validators.required, Validators.email]],
     phone: ['', [Validators.required, Validators.pattern(/^\d{11}$/)]],
      address: [''],
      dateOfBirth: ['', Validators.required],
      courseIds: [[], courseLimitValidator]
    });
  }

  ngOnInit(): void {
  this.courseService.getAllCourses().subscribe({
    next: (data) => {
      this.courses = data;
    },
    error: (err) => {
      console.error('Error loading courses:', err);
      this.errorModalService.show('Unable to load courses! Check server is running');
    }
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
          this.errorModalService.show("Unable to Submit!  Check server is running")
          console.error("Error saving student:", err);
        }
      });
    } else {
      alert("Form is invalid!");
    }
  }
}
