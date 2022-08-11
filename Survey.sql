create database dbSurvey

use dbSurvey

drop table EmployeeTable

CREATE TABLE EmployeeTable(
SNo INT IDENTITY(1,1),
EmployeeID INT,
FirstName VARCHAR(10),LastName VARCHAR(10),
MailID VARCHAR(30),Designation VARCHAR(20),
Q1 VARCHAR(10),Q2 VARCHAR(50),Q3 VARCHAR(50),
Q4 VARCHAR(50),Q5 VARCHAR(10),Q6 VARCHAR(200),
Q7 VARCHAR(200),Q8 VARCHAR(200),Q9 VARCHAR(50),Q10 INT)


CREATE PROC InsertEmp(@EmployeeID INT,@FirstName varchar(10),@LastName varchar(10),@MailID varchar(30),@Designation varchar(20),
@Q1 VARCHAR(10),@Q2 VARCHAR(50),@Q3 VARCHAR(50),
@Q4 VARCHAR(50),@Q5 VARCHAR(10),@Q6 VARCHAR(200),
@Q7 VARCHAR(200),@Q8 VARCHAR(200),@Q9 VARCHAR(50),@Q10 INT)
AS
BEGIN
   INSERT INTO EmployeeTable VALUES(@EmployeeID,@FirstName,@LastName,@MailID,@Designation,@Q1,@Q2,@Q3,@Q4,@Q5,@Q6,@Q7,@Q8,@Q9,@Q10)
END

CREATE PROC GetEmp
AS
BEGIN
SELECT * FROM EmployeeTable
END

EXEC PROC InsertEmp

select * from EmployeeTable

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

CREATE TABLE CandidateTable(
SNo INT IDENTITY(1,1), 
FName VARCHAR(10),LName VARCHAR(10),
MailId VARCHAR(30),Experience VARCHAR(30),
Q1 VARCHAR(50),Q2 VARCHAR(50),Q3 VARCHAR(50),
Q4 VARCHAR(50),Q5 VARCHAR(100),Q6 VARCHAR(50),
Q7 VARCHAR(200),Q8 VARCHAR(200),Q9 VARCHAR(200),
Q10 INT
)

CREATE PROC InsertCandi(@FName VARCHAR(10),@LName VARCHAR(10),
@MailId VARCHAR(30),@Experience VARCHAR(30),@Q1 VARCHAR(50),@Q2 VARCHAR(50),@Q3 VARCHAR(50),
@Q4 VARCHAR(50),@Q5 VARCHAR(100),@Q6 VARCHAR(50),
@Q7 VARCHAR(200),@Q8 VARCHAR(200),@Q9 VARCHAR(200),
@Q10 INT)
AS
BEGIN
   INSERT INTO CandidateTable VALUES(@FName,@LName,@MailId,@Experience,@Q1,@Q2,@Q3,@Q4,@Q5,@Q6,@Q7,@Q8,@Q9,@Q10)
END

CREATE PROC GetCandi
AS
BEGIN
SELECT * FROM CandidateTable
END

select * from CandidateTable

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