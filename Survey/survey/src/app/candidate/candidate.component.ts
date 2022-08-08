import { Component, OnInit } from '@angular/core';
import { Candidate } from 'src/models/candidate';
import { CandidateService } from 'src/services/candidate.service';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.css']
})
export class CandidateComponent implements OnInit {
  alert:boolean=false;
  candidate:Candidate;
  constructor(private candidateService:CandidateService,
              private router:Router) { 
    this.candidate =  new Candidate();
  }
  csubmit(){
    this.candidateService.addCandidate(this.candidate).subscribe(e=>{
      console.log(e);
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
  creset(){
    window.location.reload();
  }
  closeAlert()
  {
    this.alert=false;
  }
  chooseIp(value:any){
    this.candidate.cq3=value.value
  }
  back(){
    this.router.navigate(['/'])
  }

  ngOnInit(): void {
  }

}
