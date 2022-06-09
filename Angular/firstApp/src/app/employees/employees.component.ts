import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee';
import { ExmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {
employees:Employee[];
totalLikes:number;
  constructor(private employeeService:ExmployeeService) {
    this.employees = this.employeeService.getEmployees();
    this.totalLikes = 0;
   }
   showLikes(){
    this.totalLikes = 0;
     this.employees.forEach(element => {
       this.totalLikes= this.totalLikes+element.likes;
     });
   }
  ngOnInit(): void {
  }
  getEmployees(){
    this.employeeService.getEmployeesFromAPI().subscribe(data=>
      {
          console.log(data);
          this.employees = data as Employee[];
      })
  }
}
