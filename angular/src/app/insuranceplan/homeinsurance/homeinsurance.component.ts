import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { HomeinsuranceService } from '../../services/homeinsurance.service';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { HomeinsuranceModule } from '../../models/homeinsurance/homeinsurance.module'; // Corrected import path
import { ActivatedRoute } from '@angular/router';
import { AppAuthService } from '@shared/auth/app-auth.service';
import { AppSessionService } from '@shared/session/app-session.service';

@Component({
  selector: 'app-homeinsurance',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './homeinsurance.component.html',
  styleUrls: ['./homeinsurance.component.css'] // Corrected styleUrls
})
export class HomeinsuranceComponent {
  addhomeinsurance: FormGroup = new FormGroup({
    YearlyCoverage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    InsuranceLevel: new FormControl(0, [Validators.required]),
    Quotation: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    WaterDamage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    GlassBreakage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    NaturalHazard: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    AttemptedTheft: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    FiresAndExplosion: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)])
  });
  userId: number;
  constructor(public homeinsuranceService: HomeinsuranceService,public auth :AppAuthService,public route : ActivatedRoute,public  appSessionService: AppSessionService) {}
  ngOnInit(): void {
    // Accessing the user ID from the AppSessionService
    this.userId = this.appSessionService.userId;
    console.log('User ID:', this.userId); // This will log the user ID to the console
  }
  addhome() {
    if (this.addhomeinsurance.valid) {
      const formValue = this.addhomeinsurance.value;
      const newAdd: HomeinsuranceModule = new HomeinsuranceModule(
        formValue.YearlyCoverage,
        formValue.InsuranceLevel,
        formValue.Quotation,
        this.userId, // Assuming CompanyId is fixed or obtained elsewhere
        formValue.WaterDamage,
        formValue.GlassBreakage,
        formValue.NaturalHazard,
        formValue.AttemptedTheft,
        formValue.FiresAndExplosion
      );
      
      console.log('Payload:', newAdd); // Log the payload

      this.homeinsuranceService.add(newAdd).subscribe(
        response => {
          console.log('Home insurance added successfully', response);
        },
        error => {
          console.error('Error adding home insurance', error);
        }
      );
    } else {
      console.error('Form is invalid');
    }
  }
}
