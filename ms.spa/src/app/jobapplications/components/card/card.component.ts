import { Component, Input, OnInit } from '@angular/core';
import { JobApplication } from '../../interfaces/jobapplication.interface';

@Component({
  selector: 'jobapplication-card',
  templateUrl: './card.component.html',
  styles: [],
})
export class CardComponent implements OnInit {
  @Input()
  public jobApplication!: JobApplication;

  ngOnInit(): void {
    if (!this.jobApplication) {
      throw Error('JobApplication property is required');
    }
  }
}
