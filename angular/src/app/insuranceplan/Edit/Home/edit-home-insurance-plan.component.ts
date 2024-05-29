import { Component, OnDestroy, OnInit } from '@angular/core';
import { EditHomeinsuranceModule } from '@app/models/homeinsurance/Edithomeinsurance.module';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Subscription } from 'rxjs';
import { HomeinsuranceService } from '@app/services/homeinsurance.service';
import { ActivatedRoute } from '@angular/router';
import { AppSessionService } from '@shared/session/app-session.service';




@Component({
  selector: 'app-edit-home-insurance-plan',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './edit-home-insurance-plan.component.html',
  styleUrl: './edit-home-insurance-plan.component.css'
})
export class EditHomeInsurancePlanComponent implements OnInit, OnDestroy {
  public EditObj: EditHomeinsuranceModule = new EditHomeinsuranceModule(0,0, 0, 0, 0,0, 0, 0, 0, 0);
  Edithomeform: FormGroup;
  sub: Subscription;

  constructor(
    public homeservices: HomeinsuranceService,
    public activateRoute: ActivatedRoute,
    public apps:AppSessionService ) {}

  ngOnInit(): void {
    this.sub = this.activateRoute.params.subscribe(param => {
      this.homeservices.GetById(param['id']).subscribe(
        {
          next: (data) => {
            debugger;
            this.EditObj = data;
            console.log('home insurance fetched successfully', data);
            this.updateFormWithData(data); // Update form with fetched data
      
          },
          error: (error) => {
            console.error('Error fetching home insurance', error);
          }
        }
      );
    });
    this.Edithomeform = new FormGroup({
      YearlyCoverage: new FormControl(this.EditObj.YearlyCoverage, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      InsuranceLevel: new FormControl(this.EditObj.Level, [Validators.required]),
      Quotation: new FormControl(this.EditObj.Quotation, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      WaterDamage: new FormControl(this.EditObj.GlassBreakage,[Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      GlassBreakage: new FormControl(this.EditObj.AttemptedTheft, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      NaturalHazard: new FormControl(this.EditObj.FiresAndExplosion, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      FiresAndExplosion: new FormControl(this.EditObj.NaturalHazard, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
      AttemptedTheft: new FormControl(this.EditObj.WaterDamage, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)])
    });
  }

  ngOnDestroy(): void {
    if (this.sub) {
      this.sub.unsubscribe();
    }
  }

  updateFormWithData(data: any): void {
    // Patch the form controls with the data
    this.Edithomeform.patchValue({
      YearlyCoverage: data.yearlyCoverage,
      InsuranceLevel: data.level,
      Quotation: data.quotation,
      WaterDamage: data.WaterDamage,
      GlassBreakage: data.GlassBreakage,
      NaturalHazard: data.NaturalHazard,
      AttemptedTheft: data.AttemptedTheft,
      FiresAndExplosion: data.FiresAndExplosion
    });
  }
  

  EditHealth() {
    if (this.Edithomeform.valid) {
      debugger;
      const formValue = this.Edithomeform.value;
      const healthObj: EditHomeinsuranceModule = new EditHomeinsuranceModule(
        this.EditObj.id,
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

      console.log('Payload:', healthObj); // Log the payload to verify
      this.homeservices.Edit(healthObj).subscribe(
        {
          next:(data) => {
            console.log('home insurance updated successfully', data);
          },
          error:(error) => {
            console.error('Error updating home insurance', error);
          }
        }       
      );
    } else {
      console.error('Form is invalid');
    }
  }
}
