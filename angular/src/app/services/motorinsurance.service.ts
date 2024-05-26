import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import{ MotorinsuranceModule } from '../models/motorinsurance/motorinsurance.module'
import { FormGroup } from '@angular/forms';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class MotorinsuranceService {
  private baseurl:string="https://localhost:44311/api/services/app/MotorInsurancePlanService/Create"
  constructor(public httpclinte :HttpClient ) { }
  addmotor(motorinsurance: MotorinsuranceModule): Observable<any> {
    return this.httpclinte.post<any>(this.baseurl, motorinsurance);
  }
}
