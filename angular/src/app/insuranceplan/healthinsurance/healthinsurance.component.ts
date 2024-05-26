import { CommonModule } from '@angular/common';
import { Component, numberAttribute } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { HealthinsuranceService } from '../../services/healthinsurance.service';
import { HealthinsuranceModule } from '../../models/healthinsurance/healthinsurance.module';
import{AppAuthService} from '../../../shared/auth/app-auth.service'
import { ActivatedRoute } from '@angular/router';
import { AppSessionService } from '@shared/session/app-session.service';

@Component({
  selector: 'app-healthinsurance',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './healthinsurance.component.html',
  styleUrls: ['./healthinsurance.component.css']
})
export class HealthinsuranceComponent {
  addhealthform: FormGroup = new FormGroup({
    YearlyCoverage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    InsuranceLevel: new FormControl(0, [Validators.required]),
    Quotation: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    MedicalNetwork: new FormControl(null, [Validators.required]),
    ClinicsCoverage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    HospitalizationAndSurgery: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    OpticalCoverage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    DentalCoverage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)])
  });
  userId: number;
  constructor(public healthService: HealthinsuranceService , public auth :AppAuthService,public route : ActivatedRoute,public  appSessionService: AppSessionService) {}
 
  
  


  



  ngOnInit(): void {
    // Accessing the user ID from the AppSessionService
    this.userId = this.appSessionService.userId;
    console.log('User ID:', this.userId); // This will log the user ID to the console
  }

  
  
  addhealth() {
    if (this.addhealthform.valid) {
      const formValue = this.addhealthform.value;
      const healthObj: HealthinsuranceModule = new HealthinsuranceModule(
        formValue.YearlyCoverage,
        formValue.InsuranceLevel,
        formValue.Quotation,
        this.userId, // Assuming CompanyId is fixed or obtained elsewhere
        formValue.MedicalNetwork,
        formValue.ClinicsCoverage,
        formValue.HospitalizationAndSurgery,
        formValue.OpticalCoverage,
        formValue.DentalCoverage
      );

      console.log('Payload:', healthObj); // Log the payload to verify

      this.healthService.add(healthObj).subscribe(
        response => {
          console.log('Health insurance added successfully', response);
        },
        error => {
          console.error('Error adding health insurance', error);
        }
      );
    } else {
      console.error('Form is invalid');
    }
  }
}
