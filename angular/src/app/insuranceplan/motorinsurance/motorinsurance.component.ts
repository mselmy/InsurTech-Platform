import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { MotorinsuranceService } from '../../services/motorinsurance.service';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { AddMotorInsurancePlan } from '@app/models/motorinsurance/AddMotorInsurance.module';
import { AppSessionService } from '@shared/session/app-session.service';

@Component({
  selector: 'app-motorinsurance',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, FormsModule],
  templateUrl: './motorinsurance.component.html',
  styleUrls: ['./motorinsurance.component.css'] // Note the change to styleUrls for array
})
export class MotorinsuranceComponent {
  addmotorform: FormGroup = new FormGroup({
    YearlyCoverage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    Level: new FormControl(0, [Validators.required]), // Rename to Level
    Quotation: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    PersonalAccident: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    Theft: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    ThirdPartyLiability: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    OwnDamage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    LegalExpenses: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
  });

  constructor(public motorservice: MotorinsuranceService,public apps:AppSessionService) {}

  updateFormWithData(): void {

    this.addmotorform.patchValue({
      YearlyCoverage: null,
      InsuranceLevel:null,
      Quotation: null,
      PersonalAccident: null,
      Theft: null,
      ThirdPartyLiability: null,
      OwnDamage: null,
      LegalExpenses:null
    });
  }
  
  addmotor() {
    if (this.addmotorform.valid) {
      const formValue = this.addmotorform.value;
      debugger;
      const newaddmotor: AddMotorInsurancePlan = new AddMotorInsurancePlan(
        formValue.YearlyCoverage,
        formValue.Level,
        formValue.Quotation,
        this.apps.userId,
        formValue.PersonalAccident,
        formValue.Theft,
        formValue.ThirdPartyLiability,
        formValue.OwnDamage,
        formValue.LegalExpenses
        
      );
      console.log('Payload:', newaddmotor);

      this.motorservice.addmotor(newaddmotor).subscribe(
        response => {
          console.log('Motor insurance added successfully', response);
          this.updateFormWithData();
        },
        error => {
          console.error('Error adding motor insurance', error);
        }
      );
    } else {
      console.error('Form is invalid');
    }
  }
}
