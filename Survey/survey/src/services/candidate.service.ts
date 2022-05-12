import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Candidate } from "src/models/candidate";

@Injectable()
export class CandidateService{
    constructor(private http:HttpClient) {        

    }
    addCandidate(candidate:Candidate){
        return this.http.post("http://localhost:5232/api/Candidate/Add_Candidates",candidate);
    }
    getCandidate(){
        return this.http.get("http://localhost:5232/api/Candidate/Get_Candidates");
    }
}