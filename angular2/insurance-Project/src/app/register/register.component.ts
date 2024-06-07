import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './register.component.html',
  styleUrls: [
    './register.component.css',
    './fonts/font-awesome-4.7.0/css/font-awesome.min.css',
    './fonts/iconic/css/material-design-iconic-font.css',
  ],
})
export class RegisterComponent {}
