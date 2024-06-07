// src/app/account/register/register.component.ts
import { Component } from '@angular/core';
import {
  FormBuilder,
  FormGroup,
  Validators,
  ReactiveFormsModule,
} from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RegistrationService } from '../services/registration.service';
import { RegisterData } from '../services/iregistration.service';
import {
  provideHttpClient,
  withInterceptorsFromDi,
} from '@angular/common/http';

@Component({
  selector: 'app-register',
  standalone: true,
  providers: [],
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './register.component.html',
  styleUrls: [
    './fonts/font-awesome-4.7.0/css/font-awesome.min.css',
    './fonts/iconic/css/material-design-iconic-font.css',
  ],
})
export class RegisterComponent {
  registerForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private registrationService: RegistrationService
  ) {
    this.registerForm = this.fb.group({
      name: ['', Validators.required],
      userName: ['', Validators.required],
      emailAddress: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(8)]],
      taxNumber: ['', Validators.required],
      location: ['', Validators.required],
      phoneNumber: ['', Validators.required],
    });
  }

  onSubmit() {
    if (this.registerForm.valid) {
      const registerData: RegisterData = this.registerForm.value;
      this.registrationService.registerUser(registerData).subscribe({
        next: (response) => {
          console.log('Registration successful', response);
        },
        error: (error) => {
          console.error('Registration failed', error);
        },
        complete: () => {
          console.log('Request completed');
        },
      });
    }
  }
}
