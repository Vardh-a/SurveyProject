import { Component, OnInit } from '@angular/core';
import { Candidate } from 'src/models/candidate';
import { Employee } from 'src/models/employee';
import { CandidateService } from 'src/services/candidate.service';
import { EmployeeService } from 'src/services/employee.service';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
  candidateData:any;
  employeeData:any;
  constructor(private candidateService:CandidateService,
              private employeeService:EmployeeService) { }

  ngOnInit(): void {
  }
  getCandidatedata(){
    this.candidateService.getCandidate().subscribe(data=>
    {
      console.log(data);
      this.candidateData = data as Candidate[];
    }
      );
  }
  getEmployeedata(){
    this.employeeService.getEmployee().subscribe(data=>
      {
        console.log(data);
        this.employeeData = data as Employee[];
      });
  }

}
