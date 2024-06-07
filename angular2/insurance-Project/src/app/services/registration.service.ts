import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RegisterData } from './iregistration.service'; // Adjust the path as necessary
import { Observable, of } from 'rxjs';
import { map, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class RegistrationService {
  private getAllUsersUrl =
    'https://localhost:44311/api/services/app/Company/GetAll';
  private createUserUrl =
    'https://localhost:44311/api/services/app/Company/Create';

  constructor(private http: HttpClient) {}

  checkUsernameUnique(username: string): Observable<boolean> {
    return this.http.get<any>(this.getAllUsersUrl).pipe(
      map((response) => {
        const users = response.result.items;
        return !users.some((user: any) => user.username === username);
      }),
      catchError(() => of(false))
    );
  }

  registerUser(user: RegisterData): Observable<any> {
    return this.http.post<any>(this.createUserUrl, user);
  }
}
