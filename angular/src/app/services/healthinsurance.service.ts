import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HealthinsuranceModule } from '../models/healthinsurance/healthinsurance.module';
import { EditHealthinsuranceModule} from '../models/healthinsurance/Edithealthinsurance.module';

import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class HealthinsuranceService {
  private baseurl: string = "https://localhost:44311/api/services/app/HealthInsurancePlanService/";


  constructor(public http: HttpClient) {}

  add(healthinsurance: HealthinsuranceModule): Observable<any> {
    return this.http.post<any>(`${this.baseurl}Create`, healthinsurance);
  }
Edit(healthinsurance: EditHealthinsuranceModule):Observable<any>{
  
  return this.http.put<any>(`${this.baseurl}Update`, healthinsurance);
}
GetById(id:number):Observable<any>{
  return this.http.get<any>(`${this.baseurl}Get`, { params: { Id: id.toString() } })
      .pipe(
        map(response => response.result)  
      );
}
}
