import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { EmployeeService } from 'src/services/employee.service';
import {MatSelectModule} from '@angular/material/select';
import {MatTableModule} from '@angular/material/table';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './employee/employee.component';
import { CandidateComponent } from './candidate/candidate.component';
import { CandidateService } from 'src/services/candidate.service';
import { HomeComponent } from './home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ViewComponent } from './view/view.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ViewempComponent } from './viewemp/viewemp.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    CandidateComponent,
    HomeComponent,
    ViewComponent,
    ViewempComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatSelectModule,
    MatTableModule,
    NgbModule
  ],
  providers: [EmployeeService,CandidateService],
  bootstrap: [AppComponent]
})
export class AppModule { }
