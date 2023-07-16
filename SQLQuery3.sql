--Select
--Select ContactName, CompanyName, City From Customers

Select * from Customers where City = 'london'

select * from Products where CategoryID = 1 and UnitPrice <= 10

select * from Products order by UnitPrice desc

select count(*) Adet from Products where CategoryID = 3

select CategoryID, count(*) from Products group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice<10 
order by Products.UnitPrice asc

--DTO data transdormation object 

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

