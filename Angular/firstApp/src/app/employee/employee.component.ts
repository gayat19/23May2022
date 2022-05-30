import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Employee } from '../models/employee';
import { ExmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

@Input() employee:Employee;
@Output() countLikes = new EventEmitter();

  constructor() { 

   
  }
  increaseLike(){
    this.employee.likes = this.employee.likes+1;
    this.countLikes.emit();
  }

  ngOnInit(): void {
  }

}
