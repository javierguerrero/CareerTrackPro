import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, catchError, of } from 'rxjs';
import { JobApplication } from '../interfaces/jobapplication.interface';
import { environments } from 'src/environments/environments';

@Injectable({ providedIn: 'root' })
export class JobApplicationService {
  private baseUrl: string = environments.baseUrl;

  constructor(private http: HttpClient) {}

  getJobApplications(): Observable<JobApplication[]> {
    var results = this.http.get<JobApplication[]>(
      `${this.baseUrl}/api/jobapplications`
    );
    return results;
  }

  getJobApplicationById(id: number): Observable<JobApplication | undefined> {
    return this.http
      .get<JobApplication>(`${this.baseUrl}/api/jobapplications/${id}`)
      .pipe(catchError((error) => of(undefined)));
  }
}
