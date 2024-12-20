use Company_SD
--1.	Display the Department id, name and id and the name of its manager.
select * from Departments
select * from Employee
select dnum,Dname,Fname+''+lname As  manager
from Departments D ,Employee E
where E.SSN=D.MGRSSN
--2.	Display the name of the departments and the name of the projects under its control.
select * from Departments
select * from Project
select Dname,Pname
from Departments D,Project P
where D.Dnum=P.Dnum
--3.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select * from Dependent
select * from Employee 
select D.*,E.Fname+''+E.Lname AS Full_Name
from Dependent D,Employee E
where E.SSN=D.ESSN
--4.	Display the Id, name and location of the projects in Cairo or Alex city.
Select Pnumber,Pname,Plocation 
from Project
where City in ('Cairo','Alex')
--5.	Display the Projects full data of the projects with a name starts with "a" letter.
Select *
from Project
where Pname like 'a%'
--6.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select *
from Employee 
where Dno=30 and Salary between 1000 and 2000
--7.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select Fname+''+Lname AS Full_Name 
from Employee E inner join Works_for W
on E.SSN=W.ESSn and E.Dno=10 and W.Hours>=10
inner join
 Project P
on  P.Pnumber=W.Pno and P.Pname like 'AL Rabwah'
--8.	Find the names of the employees who directly supervised with Kamel Mohamed.
select E.Fname+''+E.Lname AS Full_Name 
from Employee E,Employee S
where S.SSN=E.Superssn and S.Fname='Kamel' and S.Lname='Mohamed'
--9.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select Fname+''+Lname AS Full_Name ,P.Pname
from Employee E , Works_for W, Project P
where E.SSN=W.ESSn and P.Pnumber=W.Pno
order by P.Pname Asc
--10.For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
select P.Pnumber,D.Dname,E.Lname,E.Address,E.Bdate
from Departments D,Project P,Employee E
where D.Dnum=P.Dnum and E.SSN=D.MGRSSN  and p.City like 'Cairo'
--11.	Display All Data of the managers
select M.*
from Departments D,Employee M
where M.SSN=D.MGRSSN
--12.	Display All Employees data and the data of their dependents even if they have no dependents
Select E.* ,D.*
from Employee E left outer Join Dependent D
on E.SSN=D.ESSN
--13.Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
insert into Employee (Fname, Lname, SSN, Dno, Superssn, Salary)
Values ('Mohamed', 'Reda', 102672, 30, 112233, 3000);
--14.	Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
insert into Employee (Fname, Lname, SSN, Dno)
Values ('Ahmed', 'Mohamed', 102660, 30);
--15.Upgrade your salary by 20 % of its last value.
update Employee
set Salary = Salary * 1.20
where SSN = 102672;

