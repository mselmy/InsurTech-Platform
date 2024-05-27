import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { MotorinsuranceService } from '../../services/motorinsurance.service';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { MotorinsuranceModule } from '@app/models/motorinsurance/motorinsurance.module';

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
    categoryName: new FormControl('', [Validators.required]), // Add this
    companyName: new FormControl('', [Validators.required]), // Add this
    requestNumber: new FormControl(null, [Validators.required]), // Add this
    Level: new FormControl(0, [Validators.required]), // Rename to Level
    Quotation: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    CompanyId: new FormControl(null, [Validators.required]), // Add this
    PersonalAccident: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    Theft: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    ThirdPartyLiability: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    OwnDamage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    LegalExpenses: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
  });

  constructor(public motorservice: MotorinsuranceService) {}

  addmotor() {
    if (this.addmotorform.valid) {
      const formValue = this.addmotorform.value;
      const newaddmotor: MotorinsuranceModule = new MotorinsuranceModule(
        formValue.YearlyCoverage,
        formValue.categoryName,
        formValue.companyName,
        formValue.requestNumber,
        formValue.Level,
        formValue.Quotation,
        formValue.CompanyId,
        formValue.PersonalAccident,
        formValue.Theft,
        formValue.ThirdPartyLiability,
        formValue.OwnDamage,
        formValue.legalExpenses
      );
      console.log('Payload:', newaddmotor);
      this.motorservice.addmotor(newaddmotor).subscribe(
        response => {
          console.log('Motor insurance added successfully', response);
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
