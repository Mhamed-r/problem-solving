use Company_SD
--1.Display all the employees Data.
Select * From Employee
--2.Display the employee First name, last name, Salary and Department number.

select Fname,lname,Salary,Dno From Employee

--3.Display all the projects names, locations and the department which is responsible about it.

select Pname,Plocation,Dnum From Project

--4-If you know that the company policy is to pay an annual commission for each employee with specific percent equals 10% of his/her annual salary .Display each employee full name and his annual commission in an ANNUAL COMM column (alias).

SELECT Fname + ' ' + Lname AS FullName,CONVERT(varchar(20), Salary * 0.10) AS ANNUAL_COMM 
FROM Employee;

--5.Display the employees Id, name who earns more than 1000 LE monthly.
Select SSN, Fname + ' ' + Lname AS FullName from Employee
where Salary>1000

--6.Display the employees Id, name who earns more than 10000 LE annually

Select SSN, Fname + ' ' + Lname AS FullName from Employee
WHERE Salary * 12 > 10000

--7.Display the names and salaries of the female employees 
select Fname + ' ' + Lname AS FullName ,Salary
from Employee
where sex='F'
--8.Display each department id, name which managed by a manager with id equals 968574.
select Dnum,Dname from Departments
where MGRSSN=968574
-- 9.Dispaly the ids, names and locations of  the pojects which controled with department 10.
select * from Project
select pnumber,Pname,Plocation from Project
where Dnum=10