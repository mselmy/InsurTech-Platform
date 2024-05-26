import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import{ MotorinsuranceService } from '../../services/motorinsurance.service'
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { MotorinsuranceModule } from '@app/models/motorinsurance/motorinsurance.module';
import { AppAuthService } from '@shared/auth/app-auth.service';
import { ActivatedRoute } from '@angular/router';
import { AppSessionService } from '@shared/session/app-session.service';

@Component({
  selector: 'app-motorinsurance',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule,FormsModule],
  templateUrl: './motorinsurance.component.html',
  styleUrl: './motorinsurance.component.css'
})
export class MotorinsuranceComponent {
  addmotorform:FormGroup=new FormGroup({
    YearlyCoverage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    InsuranceLevel: new FormControl(0, [Validators.required]),
    Quotation: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    PersonalAccident: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    Theft: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    ThirdPartyLiability: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    OwnDamage: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    LegalExpenses: new FormControl(null, [Validators.required, Validators.min(0), Validators.max(1.7976931348623157e+308)]),
    
  })
  constructor(public motorservce:MotorinsuranceService,public auth :AppAuthService,public route : ActivatedRoute,public  appSessionService: AppSessionService){}
  userId: number;
  ngOnInit(): void {
    // Accessing the user ID from the AppSessionService
    this.userId = this.appSessionService.userId;
    console.log('User ID:', this.userId); // This will log the user ID to the console
  }
  addmotor(){
    if(this.addmotorform.valid){
      const formValue = this.addmotorform.value;
      const newaddmotor:MotorinsuranceModule=new MotorinsuranceModule(
        formValue.YearlyCoverage,
        formValue.InsuranceLevel,
        formValue.Quotation,
        this.userId,
        formValue.PersonalAccident,
        formValue.Theft,
        formValue.ThirdPartyLiability,
        formValue.OwnDamage,
        formValue.LegalExpenses

      )
      console.log('Payload:', newaddmotor);
      this.motorservce.addmotor(newaddmotor).subscribe(
        response => {
          console.log('motor insurance added successfully', response);
        },
        error => {
          console.error('Error adding motor insurance', error);
        }
      )
      
    }else {
      console.error('Form is invalid');
    }

  }
}
