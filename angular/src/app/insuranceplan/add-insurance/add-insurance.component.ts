import { Component, ChangeDetectorRef, AfterViewInit } from '@angular/core';
import { trigger, transition, style, animate } from '@angular/animations';
import { RouterLink, RouterOutlet } from '@angular/router';

export const slideInAnimation = trigger('slideInAnimation', [
  transition(':enter', [
    style({ transform: 'translateY(100%)', opacity: 0 }),
    animate('1000ms ease-in', style({ transform: 'translateY(0)', opacity: 1 })) // Slower animation
  ]),
  transition(':leave', [
    animate('1000ms ease-in', style({ transform: 'translateY(100%)', opacity: 0 })) // Slower animation
  ])
]);

@Component({
  selector: 'app-add-insurance',
  standalone: true,
  imports: [RouterLink, RouterOutlet],
  templateUrl: './add-insurance.component.html',
  styleUrls: ['./add-insurance.component.css'],
  animations: [slideInAnimation]
})
export class AddInsuranceComponent implements AfterViewInit {

  constructor(private cdr: ChangeDetectorRef) {}

  ngAfterViewInit() {
    this.cdr.detectChanges();
  }
}
