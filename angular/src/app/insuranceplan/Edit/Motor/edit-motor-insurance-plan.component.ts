import { Component, OnDestroy, OnInit } from '@angular/core';
import { EditMotorinsuranceModule } from '@app/models/motorinsurance/Editmotorinsurance.module';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Subscription } from 'rxjs';
import { HomeinsuranceService } from '@app/services/homeinsurance.service';
import { ActivatedRoute } from '@angular/router';
import { MotorinsuranceService } from '@app/services/motorinsurance.service';


@Component({
  selector: 'app-edit-motor-insurance-plan',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './edit-motor-insurance-plan.component.html',
  styleUrl: './edit-motor-insurance-plan.component.css'
})
export class EditMotorInsurancePlanComponent implements OnInit,OnDestroy {
  public EditObj: EditMotorinsuranceModule = new EditMotorinsuranceModule(0,0, 0, 0, 0,0, 0, 0, 0, 0);
  Editmotorform: FormGroup;
  sub: Subscription;

  constructor(
    public motorservices: MotorinsuranceService,
    public activateRoute: ActivatedRoute) {}

  ngOnInit(): void {
    this.sub = this.activateRoute.params.subscribe(param => {
      this.motorservices.GetById(param['id']).subscribe(
        {
          next: (data) => {
            debugger;
            this.EditObj = data;
            console.log('motor insurance fetched successfully', data);
            this.updateFormWithData(data); // Update form with fetched data
      
          },
          error: (error) => {
            console.error('Error fetching motor insurance', error);
          }
        }
      );
    });
    this.Editmotorform = new FormGroup({
      YearlyCoverage: new FormControl(this.EditObj.YearlyCoverage, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      InsuranceLevel: new FormControl(this.EditObj.Level, [Validators.required]),
      Quotation: new FormControl(this.EditObj.Quotation, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      Theft: new FormControl(this.EditObj.Theft,[Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      LegalExpenses: new FormControl(this.EditObj.LegalExpenses, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      OwnDamage: new FormControl(this.EditObj.OwnDamage, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      PersonalAccident: new FormControl(this.EditObj.PersonalAccident, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      ThirdPartyLiability: new FormControl(this.EditObj.ThirdPartyLiability, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)])
    });
  }

  ngOnDestroy(): void {
    if (this.sub) {
      this.sub.unsubscribe();
    }
  }

  updateFormWithData(data: any): void {
    // Patch the form controls with the data
    this.Editmotorform.patchValue({
      YearlyCoverage: data.yearlyCoverage,
      InsuranceLevel: data.level,
      Quotation: data.quotation,
      PersonalAccident: data.PersonalAccident,
      Theft: data.Theft,
      ThirdPartyLiability: data.ThirdPartyLiability,
      OwnDamage: data.OwnDamage,
      LegalExpenses: data.LegalExpenses
    });
  }
  

  EditHealth() {
    if (this.Editmotorform.valid) {
      debugger;
      const formValue = this.Editmotorform.value;
      const healthObj: EditMotorinsuranceModule = new EditMotorinsuranceModule(
        this.EditObj.id,
        formValue.YearlyCoverage,
        formValue.InsuranceLevel,
        formValue.Quotation,
        2, // Assuming CompanyId is fixed or obtained elsewhere
        formValue.PersonalAccident,
        formValue.Theft,
        formValue.ThirdPartyLiability,
        formValue.OwnDamage,
        formValue.LegalExpenses
      );

      console.log('Payload:', healthObj); // Log the payload to verify
      this.motorservices.Edit(healthObj).subscribe(
        {
          next:(data) => {
            console.log('motor insurance updated successfully', data);
          },
          error:(error) => {
            console.error('Error updating motor insurance', error);
          }
        }       
      );
    } else {
      console.error('Form is invalid');
    }
  }
}
