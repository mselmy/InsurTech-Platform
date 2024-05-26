import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HealthinsuranceModule } from '../models/healthinsurance/healthinsurance.module';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HealthinsuranceService {
  private baseurl: string = "https://localhost:44311/api/services/app/HealthInsurancePlanService/Create";

  constructor(public http: HttpClient) {}

  add(healthinsurance: HealthinsuranceModule): Observable<any> {
    return this.http.post<any>(this.baseurl, healthinsurance);
  }
}
