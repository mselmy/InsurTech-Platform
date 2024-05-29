import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { HomeinsuranceService } from '../../services/homeinsurance.service';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { HomeinsuranceModule } from '../../models/homeinsurance/homeinsurance.module'; // Corrected import path
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

  constructor(public homeinsuranceService: HomeinsuranceService,public apps:AppSessionService) {}

  updateFormWithData(): void {
    this.addhomeinsurance.patchValue({
      YearlyCoverage: null,
      InsuranceLevel: null,
      Quotation: null,
      WaterDamage: null,
      GlassBreakage: null,
      NaturalHazard: null,
      AttemptedTheft: null,
      FiresAndExplosion: null
    });
  }

  addhome() {
    if (this.addhomeinsurance.valid) {
      const formValue = this.addhomeinsurance.value;
      const newAdd: HomeinsuranceModule = new HomeinsuranceModule(
        formValue.YearlyCoverage,
        formValue.InsuranceLevel,
        formValue.Quotation,
       this.apps.userId,
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
          this.updateFormWithData();
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
