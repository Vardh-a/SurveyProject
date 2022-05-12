import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/models/employee';
import { EmployeeService } from 'src/services/employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  alert:boolean=false;
employee:Employee;
  constructor(private employeeService:EmployeeService) { 
    this.employee =  new Employee();
  }
  submit(){
    this.employeeService.addEmployee(this.employee).subscribe(e=>{
      console.log(e);
    });    
    this.employee =new Employee();
    this.alert=true;
  }
  reset(){
    this.employee = new Employee();
  }
  closeAlert()
  {
    this.alert=false;
  }

  ngOnInit(): void {
  }

}
