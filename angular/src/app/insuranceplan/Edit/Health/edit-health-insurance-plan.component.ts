import { Component, OnInit, OnDestroy } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HealthinsuranceService } from '../../../services/healthinsurance.service';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { EditHealthinsuranceModule } from '@app/models/healthinsurance/Edithealthinsurance.module';

@Component({
  selector: 'app-edit-health-insurance-plan',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './edit-health-insurance-plan.component.html',
  styleUrls: ['./edit-health-insurance-plan.component.css']
})
export class EditHealthInsurancePlanComponent implements OnInit, OnDestroy {
  public EditObj: EditHealthinsuranceModule = new EditHealthinsuranceModule(0,0, 0, 0, 0, "", 0, 0, 0, 0);
  Edithealthform: FormGroup;
  sub: Subscription;

  constructor(
    public healthService: HealthinsuranceService,
    public activateRoute: ActivatedRoute) {}

  ngOnInit(): void {
    this.sub = this.activateRoute.params.subscribe(param => {
      this.healthService.GetById(param['id']).subscribe(
        {
          next: (data) => {
            debugger;
            this.EditObj = data;
            console.log('Health insurance fetched successfully', data);
            this.updateFormWithData(data); // Update form with fetched data
      
          },
          error: (error) => {
            console.error('Error fetching health insurance', error);
          }
        }
      );
    });
    this.Edithealthform = new FormGroup({
      YearlyCoverage: new FormControl(this.EditObj.YearlyCoverage, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      InsuranceLevel: new FormControl(this.EditObj.Level, [Validators.required]),
      Quotation: new FormControl(this.EditObj.Quotation, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      MedicalNetwork: new FormControl(this.EditObj.MedicalNetwork, [Validators.required]),
      ClinicsCoverage: new FormControl(this.EditObj.ClinicsCoverage, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      HospitalizationAndSurgery: new FormControl(this.EditObj.HospitalizationAndSurgery, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      OpticalCoverage: new FormControl(this.EditObj.OpticalCoverage, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      DentalCoverage: new FormControl(this.EditObj.DentalCoverage, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)])
    });
  }

  ngOnDestroy(): void {
    if (this.sub) {
      this.sub.unsubscribe();
    }
  }

  updateFormWithData(data: any): void {
    // Patch the form controls with the data
    this.Edithealthform.patchValue({
      YearlyCoverage: data.yearlyCoverage,
      InsuranceLevel: data.level,
      Quotation: data.quotation,
      MedicalNetwork: data.medicalNetwork,
      ClinicsCoverage: data.clinicsCoverage,
      HospitalizationAndSurgery: data.hospitalizationAndSurgery,
      OpticalCoverage: data.opticalCoverage,
      DentalCoverage: data.dentalCoverage
    });
  }
  

  EditHealth() {
    if (this.Edithealthform.valid) {
      debugger;
      const formValue = this.Edithealthform.value;
      const healthObj: EditHealthinsuranceModule = new EditHealthinsuranceModule(
        this.EditObj.id,
        formValue.YearlyCoverage,
        formValue.InsuranceLevel,
        formValue.Quotation,
        2, // Assuming CompanyId is fixed or obtained elsewhere
        formValue.MedicalNetwork,
        formValue.ClinicsCoverage,
        formValue.HospitalizationAndSurgery,
        formValue.OpticalCoverage,
        formValue.DentalCoverage
      );

      console.log('Payload:', healthObj); // Log the payload to verify
      this.healthService.Edit(healthObj).subscribe(
        {
          next:(data) => {
            console.log('Health insurance updated successfully', data);
          },
          error:(error) => {
            console.error('Error updating health insurance', error);
          }
        }       
      );
    } else {
      console.error('Form is invalid');
    }
  }
}
