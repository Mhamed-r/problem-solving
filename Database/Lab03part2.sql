Create DataBase Test
use Test
Create Table Instructor
(
 ID int primary Key,
 Hiredate date default Getdate(),
 Address varchar(50)check (Address in ('cairo', 'alex')),
 Salary int check (Salary between 1000 and 5000)default 3000 ,
 OverTime int Unique,
 Birthdate date,
 Fname varchar(50),
 Lnamed varchar(50),
 Age as (year(getdate())-year(Birthdate)),
 NetSalary as (Salary + OverTime)

)
drop table Instructor

Create Table Course
(
 ID int primary Key,
 Cname varchar(50),
 Duration int Unique


)
drop Table Corse

Create Table Teach
(
 InstID int,
 CID int
 constraint c1 primary Key(InstID , CID),
 constraint c2 foreign key (InstID) references Instructor(ID) on delete Cascade on update Cascade ,

)
Create Table Lab
(
 ID int,
 CID int,
 Location varchar(50),
 Capacity int check (Capacity < 20),
 constraint c3 primary Key (ID,CID),
 constraint c4 foreign key (CID) references Course(ID)on delete Cascade on update Cascade

)