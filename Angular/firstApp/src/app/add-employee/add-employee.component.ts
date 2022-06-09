import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from '../models/employee';
import { ExmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  employee:Employee;
  constructor(private employeeService:ExmployeeService,private router:Router) { 
    this.employee = new Employee();
  }

  insertEmployee(epic){
    if(epic.files.count>0)
      this.employee.pic = "assets/images/"+epic.files.item(0).name;
    this.employeeService.addEmployee(this.employee);
    this.employee = new Employee();
    alert('Employee added');
    this.router.navigate(['show']);
  }
  ngOnInit(): void {
  }

}
