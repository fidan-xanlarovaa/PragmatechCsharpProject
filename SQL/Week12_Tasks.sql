
--Number 1 and 2

/* Task like
-- HumanResource.Employee
-- NationalIDNumber sutunu icerisinde 96 olan
-- JobTitle deyeri ReSearch ile baslayan
-- Gender M olan 
-- iscilerin getirilmesi.

-- Sales.SalesOrderDetail 
-- ProductID deyeri 100-den boyuk 1000-den kicik
-- CarrierTrackingNumber son iki deyeri 'AE'
-- sifaris detallarinin getirilmesi.
*/

select * from HumanResources.Employee where NationalIDNumber like '%96%' and JobTitle like 'ReSearch%' and Gender='M'

select * from Sales.SalesOrderDetail where  ProductID  between 100 and 1000 and CarrierTrackingNumber like '%AE' 


--Number 3
/*
Production.Product,
Production.ProductSubcategory,
Production.ProductCategory    

cedvellerinden istifade ederek  asagidaki kimi resultin getirilmesi ucun query yazin
-- ProductId
-- Name
-- CategoryName
-- SubCategoryName
-- ListPrice  

*/
select p.ProductID,p.Name as productName,c.Name as CategoryName,s.Name as SubCategoryName,p.ListPrice from Production.Product as p 
inner join Production.ProductSubcategory  s on p.ProductSubCategoryID=s.ProductSubCategoryID
inner join Production.ProductCategory as c on s.ProductCategoryID=c.ProductCategoryID


--Number 4
/*
Production.Product,Production.ProductModel cedvellerinden istifade ederek
asagidaki kimi resultin getirilmesi ucun query yazin

Name,ModelName, Size,Color

Size null ola bilmez.
*/
select p.Name,m.Name,p.Color,p.Size from Production.Product as p
inner join Production.ProductModel as m on p.ProductModelID=m.ProductModelID where p.size is not null



--Number 5

/*
Production.Product
Production.ProductSubcategory
Production.ProductCategory

cedvellerinden istifade ederek asagidaki kimi resultin getirilmesi ucun query yazin

Id,Name,CategoryName,SubCategoryName

680	HL Road Frame - Black, 58	Components	Road Frames
706	HL Road Frame - Red, 58	Components	Road Frames
707	Sport-100 Helmet, Red	Accessories	Helmets
708	Sport-100 Helmet, Black	Accessories	Helmets
709	Mountain Bike Socks, M	Clothing	Socks
710	Mountain Bike Socks, L	Clothing	Socks
711	Sport-100 Helmet, Blue	Accessories	Helmets
*/
select p.ProductID as Id,p.Name as [Name],c.name as category,s.Name as SubCategoryName from Production.Product as p 
inner join Production.ProductSubcategory as s on p.ProductSubcategoryID=s.ProductSubcategoryID
inner join Production.ProductCategory as c on c.ProductCategoryID=s.ProductCategoryID 


--Number 6
/*
Production.Product
cedvellerinden istifade ederek asagidaki kimi resultin getirilmesi ucun query yazin

Size, Color, SafetyStockLevel sayi

Size ve Color null ola bilmez.

XL	Black	4
XL	Multi	4
XL	Yellow	4
S	Black	20
S	Blue	4
S	Multi	8
S	Yellow	4
M	Black	20

*/

select Size,Color,Sum(SafetyStockLevel) from Production.Product where Size is not null and Color is not null group by Color,Size order by size desc



--Number 7
/*
Production.Product , Sales.SalesOrderDetail 
cedvellerinden istifade ederek Color-a ve Size gore qruplasdirilmis Size (tersden) gore siralanmis query yazin. 

Color	Size ProductCount	Unitprice
Multi	XL	 770416	        39989,5456
Yellow	XL	 799136	        37925,8154
Black	S	 2020174	        83236,7571
Blue	S	 589248	        29917,39
Multi	S	 503382	        33921,9236
Yellow	S	 631677	        31970,7184
White	M	 651574	        5332,1466
*/

select p.Color,p.Size,SUM(p.ProductID) as ProductCount, Sum(s.UnitPrice) as Unitprice from Production.Product as p inner join Sales.SalesOrderDetail s on p.ProductID=s.ProductID
group by p.Color,p.Size having size is not null order by p.Size desc 


--Number 8
/*
  Person.Person
  Person.PersonPhone
  Person.PhoneNumberType
  cedvellerinden istifade ederek asagidaki kimi resultin getirilmesi ucun query yazin
  BusinessEntityID	    Fullname	    Type	   Number
  285	                Syed Abbas	    Work	926-555-0182
  293	                Catherine Abel	Cell	747-555-0171
  295	                Kim Abercrombie	Work	334-555-0137
  2170	                Kim Abercrombie	Work	919-555-0100
  38	                Kim Abercrombie	Cell	208-555-0114
  211	                Hazem Abolrous	Work	869-555-0125
  2357	                Sam Abolrous	Work	567-555-0100
  */

  select p.BusinessEntityID, p.FirstName+' '+p.LastName as FullName,t.Name as [Type],ph.PhoneNumber from Person.Person as p
  inner join Person.PersonPhone as ph on p.BusinessEntityID=ph.BusinessEntityID
  inner join  Person.PhoneNumberType as t on ph.PhoneNumberTypeID=t.PhoneNumberTypeID