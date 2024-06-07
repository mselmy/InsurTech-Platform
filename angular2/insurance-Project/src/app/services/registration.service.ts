import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { RegisterData } from './iregistration.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class RegistrationService {
  constructor(private http: HttpClient) {}
  private apiUrl = 'https://localhost:44311/api/services/app/Company/Create';

  registerUser(user: RegisterData): Observable<any> {
    return this.http.post(this.apiUrl, user);
  }
}
