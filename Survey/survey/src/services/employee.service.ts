import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Employee } from "../models/employee";

@Injectable()
export class EmployeeService{
    constructor(private http:HttpClient) {        

    }
    addEmployee(employee:Employee){
        return this.http.post("http://localhost:5232/api/Employee/Add_Employee",employee);
    }
    getEmployee(){
        return this.http.get("http://localhost:5232/api/Employee/Get_Employee");
    }
}