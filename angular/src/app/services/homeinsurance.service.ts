import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { HomeinsuranceModule } from "../models/homeinsurance/homeinsurance.module";
import { FormGroup } from "@angular/forms";
import { Observable } from "rxjs";
import { EditHealthinsuranceModule } from "@app/models/healthinsurance/Edithealthinsurance.module";
import { map } from "rxjs/operators";
import { EditHomeinsuranceModule } from "@app/models/homeinsurance/Edithomeinsurance.module";

@Injectable({
  providedIn: "root",
})
export class HomeinsuranceService {
  private baseurl: string =
    "https://localhost:44311/api/services/app/HomeInsurancePlanService/";
  constructor(public httpclinte: HttpClient) {}
  //create
  add(homeinsurance: HomeinsuranceModule): Observable<any> {
    return this.httpclinte.post<any>(this.baseurl, homeinsurance);
  }
  Edit(homeinsurance: EditHomeinsuranceModule): Observable<any> {
    return this.httpclinte.put<any>(`${this.baseurl}Update`, homeinsurance);
  }
  GetById(id: number): Observable<any> {
    return this.httpclinte
      .get<any>(`${this.baseurl}Get`, { params: { Id: id.toString() } })
      .pipe(map((response) => response.result));
  }
}
