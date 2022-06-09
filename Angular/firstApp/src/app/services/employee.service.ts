import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Employee } from "../models/employee";

@Injectable()
export class ExmployeeService{
    employees:Employee[];
    constructor(private httpClient:HttpClient){
        this.employees =[
            new Employee(101,"Ramu",21,243534,"assets/images/Pic1.jpg",1)
        ];
    }
    getEmployees(){
        return this.employees;
    }
    addEmployee(emp:Employee){
        this.employees.push(emp);
    }
    getEmployeesFromAPI(){
        var httpOptions = {
            headers: new HttpHeaders({ 'Content-Type': 'application/json',
            'Authorization': 'Bearer '+localStorage.getItem("token")?.toString() })
          };
        return this.httpClient.get("http://localhost:40496/api/Employee",httpOptions);
    }
}