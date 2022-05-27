import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee';
import { ExmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

//employee:Employee
employees:Employee[];
  constructor(private employeeService:ExmployeeService) { 
    // this.employee = 
    // new Employee(101,"Ramu",21,23243);
    this.employees = this.employeeService.getEmployees();
    console.log(this.employees);
  }

  ngOnInit(): void {
  }

}
