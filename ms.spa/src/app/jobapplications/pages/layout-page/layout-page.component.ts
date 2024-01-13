import { Component } from '@angular/core';

@Component({
  selector: 'app-layout-page',
  templateUrl: './layout-page.component.html',
  styles: [],
})
export class LayoutPageComponent {
  public sidebarItems = [
    { label: 'Applications', icon: 'label', url: './list' },
    { label: 'Add application', icon: 'add', url: './new-application' },
  ];
}
