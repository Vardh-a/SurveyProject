import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Candidate } from 'src/models/candidate';
import { CandidateService } from 'src/services/candidate.service';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
  candidateData:any;
  constructor(private candidateService:CandidateService,
              private router:Router) { }
back(){
    this.router.navigate(['/'])
  }

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

}
