import { STRING_TYPE } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { repeat } from 'rxjs';
import { Candidate } from 'src/models/candidate';
import { CandidateService } from 'src/services/candidate.service';

@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.css']
})
export class CandidateComponent implements OnInit {
  alert:boolean=false;
  candidate:Candidate;
  constructor(private candidateService:CandidateService) { 
    this.candidate =  new Candidate();
  }
  csubmit(){
    this.candidateService.addCandidate(this.candidate).subscribe(e=>{
      console.log(e);
    });    
    this.candidate =new Candidate();
    this.alert=true;
  }
  creset(){
    this.candidate = new Candidate();
  }
  closeAlert()
  {
    this.alert=false;
  }
  chooseIp(value:any){
    this.candidate.cq3=value.value
  }

  ngOnInit(): void {
  }

}
