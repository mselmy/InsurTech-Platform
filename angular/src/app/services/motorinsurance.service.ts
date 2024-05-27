import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import{ MotorinsuranceModule } from '../models/motorinsurance/motorinsurance.module';
import{ EditMotorinsuranceModule } from '../models/motorinsurance/Editmotorinsurance.module';
import { FormGroup } from '@angular/forms';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class MotorinsuranceService {
  private baseurl:string="https://localhost:44311/api/services/app/MotorInsurancePlanService/"
  constructor(public httpclinte :HttpClient ) { }
  addmotor(motorinsurance: MotorinsuranceModule): Observable<any> {
    return this.httpclinte.post<any>(`${this.baseurl}Create`, motorinsurance);
  }
  Edit(motorinsurance: EditMotorinsuranceModule):Observable<any>{
  
    return this.httpclinte.put<any>(`${this.baseurl}Update`, motorinsurance);
  }
  GetById(id:number):Observable<any>{
    return this.httpclinte.get<any>(`${this.baseurl}Get`, { params: { Id: id.toString() } })
        .pipe(
          map(response => response.result)  
        );
  }
}
