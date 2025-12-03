import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  private apiUrl = 'http://localhost:3000/students'; // json-server endpoint

  constructor(private http: HttpClient) {}
  
  // POST new student
  addStudent(student: any): Observable<any> {
    return this.http.post(this.apiUrl, student);
  }

  // GET all students
  getStudents(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
