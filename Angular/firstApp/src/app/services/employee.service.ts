import { Employee } from "../models/employee";

export class ExmployeeService{
    employees:Employee[];
    constructor(){
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
}