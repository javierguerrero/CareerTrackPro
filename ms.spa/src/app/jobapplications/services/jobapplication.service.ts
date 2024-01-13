import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { JobApplication } from '../interfaces/jobapplication.interface';
import { environments } from 'src/environments/environments';

@Injectable({ providedIn: 'root' })
export class ApplicationService {
  private baseUrl: string = environments.baseUrl;

  constructor(private http: HttpClient) {}

  getApplications(): Observable<JobApplication[]> {
    var results = this.http.get<JobApplication[]>(
      `${this.baseUrl}/jobapplications`
    );
    return results;
  }
}
