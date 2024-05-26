import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HomeinsuranceModule } from '../models/homeinsurance/homeinsurance.module';
import { FormGroup } from '@angular/forms';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HomeinsuranceService {
private baseurl:string="https://localhost:44311/api/services/app/HomeInsurancePlanService/Create";
  constructor(public httpclinte :HttpClient ) {

   }
   //create
   add(homeinsurance: HomeinsuranceModule): Observable<any> {
    return this.httpclinte.post<any>(this.baseurl, homeinsurance);
  }
}
