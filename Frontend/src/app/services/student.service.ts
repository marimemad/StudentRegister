import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Student } from '../interfaces/Models/Student';
import { ApiResponse } from '../interfaces/ApiResponse';

@Injectable({
  providedIn: 'root'
})
export class StudentService {


  constructor(private http: HttpClient) {}
  
  // POST new student
  addStudent(student: any): Observable<ApiResponse<string>> {
    console.log (student);
    const apiUrl = 'https://localhost:7284/Api/V1/Student/Create'; 
    return this.http.post<ApiResponse<string>>(apiUrl, student)  }

  // GET all students
  getStudents(): Observable<ApiResponse<Student[]>> {
    const apiUrl = 'https://localhost:7284/Api/V1/Student/List'; 
     return this.http.get<ApiResponse<Student[]>>(apiUrl)  }
}
