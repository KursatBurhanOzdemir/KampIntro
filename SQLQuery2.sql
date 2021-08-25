--Select
--ANSII Standartları

select CompanyName SirketAdi ,ContactName Adi ,City Sehir from customers

Select * from Customers where City='london' 
--case insensitive
seLeCt * from Products where CategoryID = 1 or CategoryID= 3 
seLeCt * from Products where CategoryID = 1 and UnitPrice >= 10 
--sırala demek order by
select * from Products order by CategoryID,ProductName

select COUNT(*) adet from Products where CategoryID=2

select CategoryID,Count(*) from Products group by CategoryID

select CategoryID,Count(*) from Products group by CategoryID having COUNT(*)<10

select CategoryID,Count(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10
---------
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID =Categories.CategoryID

select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID where o.CustomerID is null

SELECT count(DISTINCT Country) FROM Customers;
select * from Orders

select Products.ProductName  as [Ürün Adi], sum([Order Details].UnitPrice*[Order Details].Quantity) as [kazanılan toplam miktar] from Products
inner join [Order Details] on Products.ProductID = [Order Details].ProductID inner join Orders on 
[Order Details].OrderID = Orders.OrderID group by Products.ProductName order by [kazanılan toplam miktar] asc