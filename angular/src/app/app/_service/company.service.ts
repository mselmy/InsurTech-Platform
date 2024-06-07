import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";

export interface Company {
  name: string;
  userName: string;
  emailAddress: string;
  password: string;
  taxNumber: string;
  location: string;
  phoneNumber: string;
}

@Injectable({
  providedIn: "root",
})
export class CompanyService {
  private apiUrl = "https://localhost:44311/api/services/app/Company/Create";

  constructor(private http: HttpClient) {}

  createCompany(company: Company): Observable<any> {
    const headers = new HttpHeaders({
      "Content-Type": "application/json",
      Authorization: "null",
      "X-XSRF-TOKEN":
        "CfDJ8P_Q7srzXAFInyqiLnV8S-ezx7IwvkETEDkV__1HFq57IH_pyf2w2whF5eiht4YosH4rlPSsyCGvuFEkmqpET24yCXWPLnZsN07QVk9XMWFSXAAJWzZjYFplnprie8hqbWugHYL-PYOT9iCv8lMqyQI",
    });

    return this.http.post(this.apiUrl, company, { headers });
  }
}
