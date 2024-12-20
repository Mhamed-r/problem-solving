use Company_SD;
--1.Display (Using Union Function)
--a.The name and the gender of the dependence that's gender is Female and depending on Female Employee.
select Dependent_name,Sex
from Dependent 
where Sex='F'and ESSN in (select SSN from Employee where Sex='F' )
union
select  E.Fname+' '+E.Lname [FullName],Sex
from Employee E
where Sex='F' and SSN in (select ESSN from Dependent where Sex='F')
--b.And the male dependence that depends on Male Employee.
select Dependent_name,Sex
from Dependent 
where Sex='M'and ESSN in (select SSN from Employee where Sex='M' )
union
select  E.Fname+''+E.Lname [FullName],Sex
from Employee E
where Sex='M' and SSN in (select ESSN from Dependent where Sex='M')
--Display (Using Join Function)
select D.Dependent_name,D.Sex
from Employee E ,Dependent D
where E.SSN=D.ESSN and E.Sex='F' and D.Sex='F' 
union
select D.Dependent_name,D.Sex
from Employee E ,Dependent D
where E.SSN=D.ESSN and E.Sex='M' and D.Sex='M' 
--1.Display (Using Subquery Function)
select Dependent_name,Sex
from Dependent 
where Sex='F'and ESSN in (select SSN from Employee where Sex='F' )
union
select Dependent_name,Sex
from Dependent 
where Sex='M'and ESSN in (select SSN from Employee where Sex='M' ) 

--2.For each project, list the project name and the total hours per week (for all employees) spent on that project.
select P.Pname,sum(Hours)[Total_Hours]
From Project P,Works_for W
where P.Pnumber=W.Pno
group by P.Pname 
--3.Display the data of the department which has the smallest employee ID over all employees' ID.
select * from Departments
select D.*
From Departments D,Employee E
where D.Dnum=E.Dno and E.SSN  in (select min(SSN) from Employee) 
--group by D.Dname,D.Dnum,D.MGRSSN,D.[MGRStart Date]
--4.For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
Select D.Dname,Max(E.Salary)[maximum_Salary],Min(E.Salary)[minimum_Salary],AVG(E.Salary)[average_Salary]
From Departments D,Employee E
where D.Dnum=E.Dno
group by D.Dname
--5.List the full name of all managers who have no dependents.
Select  M.Fname+' '+M.Lname [FullName]
from Employee M ,Departments D
where  M.SSN =D.MGRSSN and D.MGRSSN not in(Select D.ESSN  From Dependent D )
--6.For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
Select D.Dname,AVG(E.Salary)[Average_Salary],D.Dnum,count(E.SSN)[Numbers_Emp]
From Departments D, Employee E
where D.Dnum=E.Dno
group by D.Dname,D.Dnum
Having avg(E.Salary)<(Select avg(Salary)From Employee)
--7.Retrieve a list of employee’s names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.
Select E.Fname+' '+E.Lname [Employee_Name],p.Pname,D.Dnum
From Project P,Employee E,Departments D,Works_for W
where E.SSN=W.ESSn and P.Pnumber=W.Pno and D.Dnum=P.Dnum
order by D.Dnum ,E.Fname,E.Lname
--8.Try to get the max 2 salaries using sub query
select Salary 
from Employee
where salary in (select top 2 Salary from Employee order by Salary Desc)
order by Salary desc
--9.Get the full name of employees that is similar to any dependent name
select E.Fname + ' ' + E.Lname as FullName
from Employee E
where E.Fname + ' ' + E.Lname in (
  select D.Dependent_name
  from Dependent D)
 --10.Display the employee number and name if at least one of them have dependents (use exists keyword)
 Select E.SSN, E.Fname + ' ' + E.Lname as FullName
 From Employee E 
 where exists (Select 1 from Dependent D where E.SSN=D.ESSN) 
 --11.In the department table insert new department called "DEPT IT”, with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
 insert into Departments (Dname,Dnum,MGRSSN,[MGRStart Date]) Values('DEPT IT',100,112233,'1-11-2006')
 --12.Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept.20 manager) 
 --a.First try to update her record in the department table
 update Departments
 Set MGRSSN=968574
where Dnum=100
--b.Update your record to be department 20 manager.
update Departments
 Set MGRSSN=102672
where Dnum=20
--c.Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
update Employee
set Superssn=102672
where SSN=102660
--13.Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
--Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).
-- Check if Mr. Kamel has dependents
Select S.Dependent_name
From Dependent S
where S.ESSN = 223344
-- Check if Mr. Kamel works as a department manager
Select D.Dnum
From Departments D
where D.MGRSSN = 223344
-- Check if Mr. Kamel supervises any employees
Select E1.SSN, E1.Fname + ' ' + E1.Lname [EmployeeName]
From Employee E1
where E1.Superssn = 223344
-- Check if Mr. Kamel works in any projects
Select P.Pname
From Project P , Works_for W 
where P.Pnumber = W.Pno and W.ESSN = 223344
begin TRY
begin transaction
update Employee
 set Superssn=102672
 where Superssn=223344
 update Departments
 set MGRSSN=102672
 where MGRSSN=223344
delete from Dependent
 where ESSN = 223344
 delete from Works_for
 where ESSn=223344
 delete from Employee
 where SSN=223344
 commit TRANSACTION
 end try
 begin CATCH
 rollback TRANSACTION 
 select ERROR_MESSAGE() 
 end CATCH
 --14.Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
 update Employee
 set Salary*=1.30
 where SSN in (Select w.ESSn from Project P ,Works_for W
 where P.Pnumber=W.Pno and P.Pname ='Al Rabwah')