 

 --  Task 1
 /*Sales.SalesOrderHeader, Sales.SalesOrderDetail cedvellerinden istifade ederek 
   --   '2011-05-31 00:00:00.000' tarixinde satis eden satis temsilcilerinin ad soyadini ve toplam lineTotal deyeri
   --   getiren query yazin.


 SalesPerson	        LineTotal
DavidCampbell	        69472.996300
GarrettVargas	        9109.168300
JillianCarson	        46695.556400
JoséSaraiva	            106251.727700
LindaMitchell	        5475.948500
MichaelBlythe	        63762.922800
PamelaAnsman-Wolfe	    24432.608800
ShuIto	                59708.320800
TsviReiter	            104419.329100*/

/*select * from Sales.SalesOrderHeader -- order data
select * from  Sales.SalesOrderDetail --line total
select * from Person.Person -- ad soyad*/

use AdventureWorks2016

select p.FirstName,p.LastName,h.OrderDate,Sum(o.LineTotal) SumOfLineTotal from Sales.SalesOrderHeader as h
inner join Person.Person p on p.BusinessEntityID=h.SalesPersonID
inner join Sales.SalesOrderDetail o on o.SalesOrderID=h.SalesOrderID
where h.OrderDate='2011-05-31 00:00:00.000'
group by p.FirstName,p.LastName,h.OrderDate
order by p.FirstName

 --Task 2
 /*
 Store procudure examples 

 2.a Person Cedveli yaradin (Id,Name,Surname,Status,Gender,CreateDate) 

 2.b Person cedveline AdventureWorks db-dan data insert eden proc yaradilmalidir.

 2.c PersonCedveli ucun asagidakilara uygun proc-lar yaradilmalidir.
 Add (insert edilen row-un idsi output olaraq GetById proc-a oturulmelidir)
 Update (update edilen row-un idsi output olaraq GetById proc-a oturulmelidir)
 Delete

 GetById (parametr olaraq id deyeri daxil edilecek)
 GetAll (parametr almayacaq)
 GetAll (Gender deyeri qebul ederse daxil edilen deyere esasen filter olacaq, daxil edilmezse 'M' ve ya 'F' olanlar getirilecek )
 GetByEmail (parametr olaraq email deyeri daxil edilecek)
 */

 create database MyDatabase

 use MyDatabase
 
 --2.a
 create table Person(
 PersonId int primary key,
 [Name] nvarchar(50) not null,
 SurName nvarchar(50) not null,
 [Status] nvarchar(50) not null,
 Gender char(1) default 'M',
 CreateData datetime default getdate(),
 Email nvarchar(50) not null
 )

--2.b
 create proc AddData
 as 
 begin
 insert into Person(PersonId,[Name] , SurName,Gender,[Status],Email )
 select p.BusinessEntityID,p.FirstName,p.LastName,e.Gender,e.JobTitle,p.FirstName+'.'+p.LastName+'@gmail.com'
 from AdventureWorks2016.Person.Person p
 inner join AdventureWorks2016.HumanResources.Employee e 
 on p.BusinessEntityID=e.BusinessEntityID
 end

 exec AddData
 
 select * from Person

--2.c

 --Add

 create proc [Add](
 @id int,
 @name nvarchar(50),
 @surname nvarchar(50),
 @status nvarchar(50),
 @gender char='M'
 )
 as 
 begin
 insert into Person
 (PersonId,[Name],SurName,[Status],Gender,Email)
 values
 (@id,@name,@surname,@status,@gender,@name+'.'+@surname+'@gmail.com')
 exec GetById @id=@id
 end

 exec [Add] @id=100000000,@name='Fidan',@surname='Xanlarova',@status='student',@gender='F' 
 exec [Add] @id=100000001,@name='Tahir',@surname='Eyvazov',@status='student'


 --Update

 create proc [Update](
 @id int,
 @name nvarchar(50),
 @surname nvarchar(50),
 @status nvarchar(50),
 @gender char='M'
 )
 as 
 begin
 update Person set
 [Name]=@name,SurName=@surname,[Status]=@status,Gender=@gender,Email=@name+'.'+@surname+'@gmail.com'
 where PersonId=@id
 exec GetById @id=@id
 end

 exec [Update] @id=100000001,@name='Nezrin',@surname='Aliyeva',@status='teacher',@gender='F' 


 --Delete

 create proc [Delete](@id int)
 as
 begin
 delete Person where PersonId=@id
 exec GetById @id=@id
 end

 exec [Delete] @id=100000001


--GetById (parametr olaraq id deyeri daxil edilecek)

create proc GetById(@id int)
as
begin
select * from Person where PersonId = @id
end

exec GetById @id=6


--GetAll (parametr almayacaq)

create proc GetAll
as
begin 
select * from Person
end

exec GetAll


--GetAll (Gender deyeri qebul ederse daxil edilen deyere esasen filter olacaq, daxil edilmezse 'M' ve ya 'F' olanlar getirilecek )

create proc GetByGender(@gender char(1)='F')
as 
begin
select * from Person where Gender=@gender
end

exec GetByGender
exec GetByGender @gender='M'


--GetByEmail (parametr olaraq email deyeri daxil edilecek

create proc GetByEmail(@email nvarchar(50))
as 
begin
select * from Person where Email=@email
end

exec GetByEmail @email='Roberto.Tamburello@gmail.com'



 
--Task 3
 /*
 Store procudure examples 

 Person Cedveli yaradin (Id,Name,Surname,Status,CreateDate) 

 PersonCedveli ucun asagidakilara uygun tek proc yaradilmalidir.
 Yaradilan proc-a verilen uygun keyword-e gore Add,Update,Delete,GetAll emeliyyatlarini
 yerine yetirmelidir.
 Add (insert edilen row-un idsi output olaraq GetById proc-a oturulmelidir)
 Update (update edilen row-un idsi output olaraq GetById proc-a oturulmelidir)
 Delete
 GetAll
 */

 create proc DoProcedure(@procedureName nvarchar(20),@id int=null,@name nvarchar(20)='',@surname nvarchar(20)='',@status nvarchar(20)='',@gender char(1)='M')
 as
 begin
 
 if @procedureName='add'
 exec [Add] @id=@id,@name=@name,@surname=@surname,@status=@status 
 
 else if @procedureName='update' 
 exec [Update] @id=@id,@name=@name,@surname=@surname,@status=@status,@gender=@gender

 else if @procedureName='delete'
 exec [Delete]  @id=@id

 else if @procedureName='getall'
 exec GetAll
 end

 exec DoProcedure @procedureName='add',@id=100000001,@name='Tahir',@surname='Eyvazov',@status='student'
 exec DoProcedure @procedureName='update',@id=100000001,@name='Nezrin',@surname='Aliyeva',@status='teacher',@gender='F' 
 exec DoProcedure @procedureName='delete',@id=100000001
 exec DoProcedure @procedureName='getall'


 --Task 4
  /*
 Dbdaki iscilerin 
 Adini,Soyadini, Islediyi Departamenti , Ise baslama tarxini, mevacibinin cemini
 getiren proc yazin

 order by mevacibinin cemine gore desc

 -- isteye gore en cox qazan en az qazan iscini
 ---- hal hazirda isden cixan butun iscileri getiren query yaza bilersiz.            end date is not null

 */
 

-- Dbdaki iscilerin  Adini,Soyadini, Islediyi Departamenti , Ise baslama tarxini, mevacibinin cemini getiren proc 

 use AdventureWorks2016

  /*select * from HumanResources.Department -- department name
 select * from HumanResources.EmployeeDepartmentHistory -- start date end date  department id
 select BusinessEntityID,Sum(Rate) from HumanResources.EmployeePayHistory group by BusinessEntityID*/

 create proc GetEmployeeIncome2
 as
 begin
 select
 p.FirstName,
 p.LastName, 
 d.[Name] as DepartmentName, 
 his.StartDate,
 Sum(pay.Rate) Income
 from Person.Person p 
 inner join HumanResources.EmployeePayHistory pay on pay.BusinessEntityID=p.BusinessEntityID
 inner join HumanResources.EmployeeDepartmentHistory his on his.BusinessEntityID=p.BusinessEntityID
 inner join HumanResources.Department d on d.DepartmentID=his.DepartmentID
 group by p.FirstName, p.LastName,d.[Name],  his.StartDate
 order by Income desc
end

exec GetEmployeeIncome2


--  en cox qazan en az qazan isci

create proc GetMaxIncome
 as
 begin
 select top(1)
 p.FirstName,
 p.LastName, 
 d.[Name] as DepartmentName, 
 his.StartDate,
 Sum(pay.Rate) Income
 from Person.Person p 
 inner join HumanResources.EmployeePayHistory pay on pay.BusinessEntityID=p.BusinessEntityID
 inner join HumanResources.EmployeeDepartmentHistory his on his.BusinessEntityID=p.BusinessEntityID
 inner join HumanResources.Department d on d.DepartmentID=his.DepartmentID
 group by p.FirstName, p.LastName,d.[Name],  his.StartDate
 order by Income desc
end

exec GetMaxIncome

/*
 select
 p.FirstName,
 p.LastName, 
 d.[Name] as DepartmentName, 
 his.StartDate,
 max(
 Sum(pay.Rate))as Income
 
 from Person.Person p 
 inner join HumanResources.EmployeePayHistory pay on pay.BusinessEntityID=p.BusinessEntityID
 inner join HumanResources.EmployeeDepartmentHistory his on his.BusinessEntityID=p.BusinessEntityID
 inner join HumanResources.Department d on d.DepartmentID=his.DepartmentID  
 group by p.FirstName, p.LastName,d.[Name],  his.StartDate  */ 
 -- 2 aggregate function birlikde isleye bilmir


-- hal hazirda isden cixan butun iscileri getiren query yaza bilersiz.

create proc GetExpelledEmployees
 as
 begin
 select
 p.FirstName,
 p.LastName, 
 d.[Name] as DepartmentName, 
 his.StartDate,
 his.EndDate,
 Sum(pay.Rate) Income
 from Person.Person p 
 inner join HumanResources.EmployeePayHistory pay on pay.BusinessEntityID=p.BusinessEntityID
 inner join HumanResources.EmployeeDepartmentHistory his on his.BusinessEntityID=p.BusinessEntityID
 inner join HumanResources.Department d on d.DepartmentID=his.DepartmentID
 where his.EndDate is not null
 group by p.FirstName, p.LastName,d.[Name],  his.StartDate , his.EndDate 
 order by Income desc
end

exec GetExpelledEmployees