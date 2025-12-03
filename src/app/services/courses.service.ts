import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class CoursesService {

  private apiUrl = 'http://localhost:3000/courses'; // json-server endpoint

  constructor(private http: HttpClient) {}

    // GET all courses
  getAllCourses(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
  
}
