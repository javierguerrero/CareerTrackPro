import { Component, OnInit } from '@angular/core';
import { JobApplicationService } from '../../services/jobapplication.service';
import { ActivatedRoute, Router } from '@angular/router';
import { delay, switchMap } from 'rxjs';
import { JobApplication } from '../../interfaces/jobapplication.interface';

@Component({
  selector: 'app-application-page',
  templateUrl: './jobapplication-page.component.html',
  styles: [],
})
export class ApplicationPageComponent implements OnInit {
  public jobApplication?: JobApplication;

  constructor(
    private jobApplicationService: JobApplicationService,
    private activatedRoute: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.activatedRoute.params
      .pipe(
        delay(1000),
        switchMap(({ id }) =>
          this.jobApplicationService.getJobApplicationById(id)
        )
      )
      .subscribe((jobApplication) => {
        if (!jobApplication)
          return this.router.navigate(['/jobapplications/list']);

        this.jobApplication = jobApplication;
        console.log(jobApplication);
        return;
      });
  }

  goBack(): void {
    this.router.navigateByUrl('jobapplications/list');
  }
}
