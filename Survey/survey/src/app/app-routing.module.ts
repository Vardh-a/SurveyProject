import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CandidateComponent } from './candidate/candidate.component';
import { EmployeeComponent } from './employee/employee.component';
import { HomeComponent } from './home/home.component';
import { ViewComponent } from './view/view.component';
import { ViewempComponent } from './viewemp/viewemp.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'employee',component:EmployeeComponent},
  {path:'candidate',component:CandidateComponent},
  {path:'view',component:ViewComponent},
  {path:'viewemp',component:ViewempComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
