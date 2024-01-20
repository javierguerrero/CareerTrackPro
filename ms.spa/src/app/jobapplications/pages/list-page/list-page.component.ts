import { Component, OnInit } from '@angular/core';
import { JobApplication } from '../../interfaces/jobapplication.interface';
import { JobApplicationService } from '../../services/jobapplication.service';

@Component({
  selector: 'app-list-page',
  templateUrl: './list-page.component.html',
  styles: [],
})
export class ListPageComponent implements OnInit {
  public jobApplications: JobApplication[] = [];

  constructor(private jobApplicationService: JobApplicationService) {}

  ngOnInit(): void {
    this.jobApplicationService
      .getJobApplications()
      .subscribe((jobApplications) => (this.jobApplications = jobApplications));
  }
}
