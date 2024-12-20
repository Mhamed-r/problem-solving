use ITI

select sum(salary) as totalsal
from Instructor

select count(ins_id) Cnt
from Instructor

select min(salary),max(salary)
from Instructor

select count(*),count(st_id),count(st_fname),count(st_age)
from Student

select avg(st_age)
from Student

select avg(isnull(st_age,0))
from Student

select sum(st_age)/count(*)
from Student

select sum(salary),dept_id
from Instructor
group by Dept_Id

select count(st_id),st_address
from Student
group by St_Address

select sum(salary),d.dept_id,dept_name
from Instructor i inner join Department d
	on d.Dept_Id=i.Dept_Id
group by d.dept_id,dept_name

select count(st_id),st_address
from Student
group by St_Address

select count(st_id),dept_id
from Student
group by Dept_Id

select count(st_id),st_address,dept_id
from Student
group by St_Address,Dept_Id

select sum(salary),dept_id
from Instructor
group by Dept_Id

select sum(salary),dept_id
from Instructor
where salary>1000
group by Dept_Id

select sum(salary),dept_id
from Instructor
group by Dept_Id

select sum(salary),dept_id
from Instructor
group by Dept_Id
having sum(salary)>26000

select sum(salary),dept_id
from Instructor
group by Dept_Id
having count(ins_id)<6
-------------------------------------
--subquery
select *
from Student
where st_age<(select avg(St_age) from Student)

select *,(select count(st_id) from Student)
from Student

select dept_name
from Department
where Dept_Id  in (select distinct Dept_Id
				  from Student
				  where Dept_Id is not null)

select distinct dept_name
from Student s inner join department d
	on d.dept_id=s.dept_id

--subquery +DML
delete from Stud_Course
where st_id=1

delete from Stud_Course
where crs_name='oop'

delete from Stud_Course
where crs_id =(select crs_id from Course where crs_name='OOP')
--------------------------------
--uset oprators
union all     union     intersect   except

select st_fname
from Student
union all
select ins_name
from Instructor

select st_fname as [ITInames]
from Student
union all
select ins_name
from Instructor

select st_fname,st_id
from Student
union all
select ins_name,ins_id
from Instructor

select convert(varchar(10),st_id)
from Student
union all
select ins_name
from Instructor

select st_fname
from Student
union   --distinct(order+unique)
select ins_name
from Instructor

select st_fname
from Student
intersect
select ins_name
from Instructor

select st_fname,st_id
from Student
intersect
select ins_name,ins_id
from Instructor

select st_fname
from Student
except
select ins_name
from Instructor
---------------------------------------------
--grouping  + Agg + having
--subqueries
--set operators
--Data types
--->numeric DT
bit   0:1  boolean  false:true  
tinyint 1 byte  -128:127
smallint 2B  -32768:+32767
int  4B
bigint 8B
--->decimal DT
smallmoney  --4B    .0000    $
money       --4B    .0000    $
real                .0000000
float               .000000000000000000000
dec   decimal   dec(5,2)  12.432 XXXX    123.33    1.3
--->string & char DT
char(10)    fixed length string    ahmed 10   ali 10   محمد على  ?????
varchar(10)  variable length string   ahmed 5   ali 3
nchar(10)   unicode language 
nvarchar(10) unicode
nvarchar(max)  --up to 2GB
--->date time DT
date    MM/dd/yyyy
time    hh:mm:12.543
time(7) hh:mm:10.5362343
smalldatetime MM/dd/yyyy hh:mm:00   --100 year
datetime MM/dd/yyyy hh:mm:ss.323
--->binary DT
binary   1010101   1101010 11110101
image
--->others
xml
sql_variant
uniqueidentifier
geography
-----------------------------------------------------
select st_fname,dept_id,st_age
from Student
order by St_Address

select st_fname,dept_id,st_age
from Student
where St_Address='mansoura'

select st_fname,dept_id,st_age
from Student
order by 1

select st_fname,dept_id,st_age
from Student
order by 3

select st_fname,dept_id,st_age
from Student
order by dept_id desc,st_age asc

select st_fname+' '+st_lname as fullname
from Student
order by fullname

select st_fname+' '+st_lname as fullname
from Student
where fullname='ahmed hassan'


select st_fname+' '+st_lname as fullname
from Student
where st_fname+' '+st_lname ='ahmed hassan'

select *
from (select st_fname+' '+st_lname as fullname
      from Student) as newtable
where fullname='ahmed hassan'

--execution order 
--from
--join
--on
--where
--group by
--having
--select
--order by
--top


--DB integrity   [system --->business rules --->corrent --->DB trust]
---->constraints [Primary key        foreign key        unique key        check]

create table depts
(
 did int primary key,
 dname varchar(20)
)

create table emps
(
 eid int ,
 ename varchar(10),
 eadd varchar(10) default 'cairo',
 hiredate date default getdate(),
 salary int,
 overtime int,
 netsal as(isnull(salary,0)+isnull(overtime,0)) persisted,  --computed+saved
 bd date,
 age as year(getdate())-year(bd), -->computed
 hour_rate int not null,
 gender varchar(1),
 dnum int,
 constraint c1 primary key(eid,ename),-->composite PK
 constraint c2 unique(overtime),
 constraint c3 unique(Salary),
 constraint c4 check(salary>1000),
 constraint c5 check(overtime between 100 and 500),
 constraint c6 check(gender='f' or gender='m'),
 constraint c7 check(eadd in('alex','mansoura','cairo')),
 constraint c8 foreign key(dnum) references depts(did)
	on delete set null  on update cascade
 )

 alter table emps drop constraint c3

 alter table emps add constraint c100 check(hour_rate>1000)

 alter table instructor add constraint c20  check(salary>1000)

  --Rule   --->global check constraint
  create rule r1 as @x>1000

  sp_bindrule r1,'instructor.salary'


--builtin functions
Aggregate functions
--date   getdate   month   day   year  datediff isdate
select isdate('dsfsdfsdf')
select isdate('1/1/2000')

--isnull coalesce
--concat
--convert

select upper(st_fname),lower(st_lname)
from Student

select len(st_fname),st_fname
from Student

select substring(st_fname,1,3)
from Student

select substring(st_fname,3,3)
from Student

select substring(st_fname,1,len(st_fname)-1)
from Student

select db_name()

select suser_name()


























--types of constraints






















