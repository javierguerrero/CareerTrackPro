import { Component, OnInit } from '@angular/core';
import { JobApplication } from '../../interfaces/jobapplication.interface';
import { ApplicationService } from '../../services/jobapplication.service';

@Component({
  selector: 'app-list-page',
  templateUrl: './list-page.component.html',
  styles: [],
})
export class ListPageComponent implements OnInit {
  public applications: JobApplication[] = [];

  constructor(private applicationService: ApplicationService) {}

  ngOnInit(): void {
    this.applicationService
      .getApplications()
      .subscribe((applications) => (this.applications = applications));
  }
}
