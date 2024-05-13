import { Routes } from '@angular/router';
import { RegistrationComponent } from './registration/registration.component';
import { SigninComponent } from './signin/signin.component';

export const routes: Routes = [
    {
    path: 'account/register',
    component: RegistrationComponent,
    title: 'register'
    },
    {
    path: 'account/signin',
    component: SigninComponent,
    title: 'Sign-in'
    }
];
