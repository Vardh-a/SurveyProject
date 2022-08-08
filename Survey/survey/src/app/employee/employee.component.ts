import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/models/employee';
import { EmployeeService } from 'src/services/employee.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  employee:Employee;
  constructor(private employeeService:EmployeeService,
              private router:Router) { 
    this.employee =  new Employee();
  }  
  submit(){
    this.employeeService.addEmployee(this.employee).subscribe(e=>{
      console.log();
    });    
    Swal.fire({
      title:'Success!!',
      text:'Your response has been recorded successfully',
      icon:'success',
      showConfirmButton:true,
      confirmButtonText:'Okay'
    }).then((result)=>{
      window.location.reload();
    })
  }  
  reset(){
    window.location.reload();
  }
  back(){
    this.router.navigate(['/'])
  }
  chooseIp(value:any){
    this.employee.q1=value.value
  }
  ngOnInit(): void {
  }

}
