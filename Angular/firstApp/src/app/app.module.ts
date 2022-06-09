import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './employee/employee.component';
import { ExmployeeService } from './services/employee.service';
import { StudentComponent } from './student/student.component';
import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { EmployeesComponent } from './employees/employees.component';
import { LoginComponent } from './login/login.component';
import { LoginService } from './services/login.service';


@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    StudentComponent,
    AddEmployeeComponent,
    EmployeesComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  // Inject Service
  providers: [ExmployeeService,LoginService],
  bootstrap: [AppComponent]
})
export class AppModule { }
