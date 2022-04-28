create database dbSurvey

use dbSurvey

create table tblEmployee(
employeeid varchar(10) primary key,
fname varchar(10),lname varchar(10),
mailid varchar(30),desg varchar(20)
)

create proc proc_InsertEmp(@eid varchar(10),@efname varchar(10),@elname varchar(10),@email varchar(30),@edesg varchar(20))
as
begin
   insert into tblEmployee values(@eid,@efname,@efname,@email,@edesg)
end

select * from tblEmployee

create table tblEmpQuestion(
employeeid varchar(10),
q1 varchar(10),q2 varchar(50),q3 varchar(50),q4 varchar(50),q5 varchar(10),q6 varchar(200),
q7 varchar(200),q8 varchar(200),q9 varchar(50),q10 int)

select * from tblEmpQuestion

create proc proc_QuestAns(@eid varchar(10),@eq1 varchar(10),@eq2 varchar(50),@eq3 varchar(50),@eq4 varchar(50),
@eq5 varchar(10),@eq6 varchar(200),@eq7 varchar(200),@eq8 varchar(200),@eq9 varchar(50),@eq10 int)
as
begin
   insert into tblEmpQuestion values(@eid,@eq1,@eq2,@eq3,@eq4,@eq5,@eq6,@eq7,@eq8,@eq9,@eq10)
end

create table tblCandidate(
fname varchar(10) primary key,lname varchar(10),
mailid varchar(30),exp varchar(30)
)

create proc proc_InsertCan(@cfname varchar(10),@clname varchar(10),@cemail varchar(30),@cexp varchar(30))
as
begin
   insert into tblCandidate values(@cfname,@cfname,@cemail,@cexp)
end
select * from tblCandidate

create table tblCanQuestion(
fname varchar(10),
q1 varchar(50),q2 varchar(50),q3 varchar(50),q4 varchar(50),q5 varchar(100),q6 varchar(50),
q7 varchar(50),q8 varchar(50),q9 varchar(200),q10 varchar(200))

create proc proc_CanQuestAns(@fname varchar(10),@eq1 varchar(50),@eq2 varchar(50),@eq3 varchar(50),@eq4 varchar(50),
@eq5 varchar(100),@eq6 varchar(50),@eq7 varchar(50),@eq8 varchar(50),@eq9 varchar(200),@eq10 varchar(200))
as
begin
   insert into tblCanQuestion values(@fname,@eq1,@eq2,@eq3,@eq4,@eq5,@eq6,@eq7,@eq8,@eq9,@eq10)
end

select * from tblCanQuestion