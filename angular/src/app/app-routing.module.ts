import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { AppRouteGuard } from '@shared/auth/auth-route-guard';
// import { HomeComponent } from './home/home.component';
import{HomeComponent} from './homePage/home/home.component'
import { AboutComponent } from './about/about.component';
import { UsersComponent } from './users/users.component';
import { TenantsComponent } from './tenants/tenants.component';
import { RolesComponent } from 'app/roles/roles.component';
import { ChangePasswordComponent } from './users/change-password/change-password.component';
import { RegistrationRequestsComponent } from './registration-requests/registration-requests.component';
import { HomeinsuranceComponent } from './insuranceplan/homeinsurance/homeinsurance.component';
import { MotorinsuranceComponent } from './insuranceplan/motorinsurance/motorinsurance.component';
import { HealthinsuranceComponent } from './insuranceplan/healthinsurance/healthinsurance.component';
import { AddInsuranceComponent } from './insuranceplan/add-insurance/add-insurance.component';
import{EditHomeInsurancePlanComponent}  from './insuranceplan/Edit/Home/edit-home-insurance-plan.component';
import {EditHealthInsurancePlanComponent } from './insuranceplan/Edit/Health/edit-health-insurance-plan.component';
import { EditMotorInsurancePlanComponent } from './insuranceplan/Edit/Motor/edit-motor-insurance-plan.component';




@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                component: AppComponent,
                children: [
                    { path: 'home', component: HomeComponent,  canActivate: [AppRouteGuard] },
                    { path: 'users', component: UsersComponent, data: { permission: 'Pages.Users' }, canActivate: [AppRouteGuard] },
                    { path: 'roles', component: RolesComponent, data: { permission: 'Pages.Roles' }, canActivate: [AppRouteGuard] },
                    { path: 'tenants', component: TenantsComponent, data: { permission: 'Pages.Tenants' }, canActivate: [AppRouteGuard] },
                    { path: 'about', component: AboutComponent, canActivate: [AppRouteGuard] },
                    { path: 'update-password', component: ChangePasswordComponent, canActivate: [AppRouteGuard] },
                    { path: 'registration-requests', component:RegistrationRequestsComponent, canActivate: [AppRouteGuard] }
                ]
            },
          
            {path:'addinsurance',component:AddInsuranceComponent,children:[
                {path:'homeinsurance',component:HomeinsuranceComponent},
                {path:'motorinsurance',component:MotorinsuranceComponent},
                {path:'healthinsurance',component:HealthinsuranceComponent},
            ]},
           
                {path:'homeinsurance/:id',component:EditHomeInsurancePlanComponent},
                {path:'motorinsurance/:id',component:EditMotorInsurancePlanComponent},
                {path:'healthinsurance/:id',component:EditHealthInsurancePlanComponent},
            
        ])
    ],
    exports: [RouterModule]
})
export class AppRoutingModule { }
