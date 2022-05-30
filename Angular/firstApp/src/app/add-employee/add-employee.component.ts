import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee';
import { ExmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  employee:Employee;
  constructor(private employeeService:ExmployeeService) { 
    this.employee = new Employee();
  }

  insertEmployee(epic){
    this.employee.pic = "assets/images/"+epic.files.item(0).name;
    this.employeeService.addEmployee(this.employee);
  }
  ngOnInit(): void {
  }

}
