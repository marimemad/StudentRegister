import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Course } from '../interfaces/Models/Course';
import { ApiResponse } from '../interfaces/ApiResponse';



@Injectable({
  providedIn: 'root'
})
export class CoursesService {


  constructor(private http: HttpClient) {}
    // GET all courses
  getAllCourses(): Observable<ApiResponse<Course[]>> { 
    const apiUrl = 'https://localhost:7284/Api/V1/Course/List';
    return this.http.get<ApiResponse<Course[]>>(apiUrl); }
}
