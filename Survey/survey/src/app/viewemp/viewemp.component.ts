import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/models/employee';
import { EmployeeService } from 'src/services/employee.service';

@Component({
  selector: 'app-viewemp',
  templateUrl: './viewemp.component.html',
  styleUrls: ['./viewemp.component.css']
})
export class ViewempComponent implements OnInit {
  employeeData:any;
  constructor(private employeeService:EmployeeService,
    private router:Router) { }

back(){
      this.router.navigate(['/'])
    }

  ngOnInit(): void {
  }
  getEmployeedata(){
    this.employeeService.getEmployee().subscribe(data=>
    {
      console.log(data);
      this.employeeData = data as Employee[];
    }
      );
  }

}
