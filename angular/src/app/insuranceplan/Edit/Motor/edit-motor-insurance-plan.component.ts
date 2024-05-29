import { Component, OnDestroy, OnInit } from '@angular/core';
import { EditMotorinsuranceModule } from '@app/models/motorinsurance/Editmotorinsurance.module';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Subscription } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { MotorinsuranceService } from '@app/services/motorinsurance.service';
import { AppSessionService } from '@shared/session/app-session.service';

@Component({
  selector: 'app-edit-motor-insurance-plan',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  
  templateUrl: './edit-motor-insurance-plan.component.html',
  styleUrl: './edit-motor-insurance-plan.component.css'
})
export class EditMotorInsurancePlanComponent implements OnInit, OnDestroy {
  public EditObj: EditMotorinsuranceModule = new EditMotorinsuranceModule(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
  Editmotorform: FormGroup;
  sub: Subscription;

  constructor(
    public motorservices: MotorinsuranceService,
    public activateRoute: ActivatedRoute,
    public apps: AppSessionService
  ) {}

  ngOnInit(): void {
    this.sub = this.activateRoute.params.subscribe(param => {
      this.motorservices.GetById(param['id']).subscribe({
        next: (data) => {
          this.EditObj = data;
          console.log('Motor insurance fetched successfully', data);
          this.updateFormWithData(data); // Update form with fetched data
        },
        error: (error) => {
          console.error('Error fetching motor insurance', error);
        }
      });
    });

    this.Editmotorform = new FormGroup({
      YearlyCoverage: new FormControl(this.EditObj.YearlyCoverage, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      Level: new FormControl(this.EditObj.Level, [Validators.required]),
      Quotation: new FormControl(this.EditObj.Quotation, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      Theft: new FormControl(this.EditObj.Theft, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      LegalExpenses: new FormControl(this.EditObj.LegalExpenses, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      OwnDamage: new FormControl(this.EditObj.OwnDamage, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      PersonalAccident: new FormControl(this.EditObj.PersonalAccident, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      ThirdPartyLiability: new FormControl(this.EditObj.ThirdPartyLiability, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)])
    });
  }

  ngOnDestroy(): void {
    if (this.sub) {
      this.sub.unsubscribe();
      console.log(this.EditObj, "destroy");
    }
  }
  updateFormWithData(data: any): void {
    this.Editmotorform.patchValue({
      YearlyCoverage: data.yearlyCoverage, 
      Level: data.level, 
      Quotation: data.quotation, 
      Theft: data.Theft, 
      LegalExpenses: data.LegalExpenses, 
      OwnDamage: data.OwnDamage, 
      PersonalAccident: data.PersonalAccident, 
      ThirdPartyLiability: data.ThirdPartyLiability 
    });
  }
  

  EditHealth() {
    if (this.Editmotorform.valid) {
      const formValue = this.Editmotorform.value;
      const healthObj: EditMotorinsuranceModule = new EditMotorinsuranceModule(
        this.EditObj.id,
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

      console.log('Payload:', healthObj); 
      this.motorservices.Edit(healthObj).subscribe({
        next: (data) => {
          console.log('Motor insurance updated successfully', data);
        },
        error: (error) => {
          console.error('Error updating motor insurance', error);
        }
      });
    } else {
      console.error('Form is invalid');
    }
  }
}
