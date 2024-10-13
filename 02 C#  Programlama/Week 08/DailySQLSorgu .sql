--en pahalı ürünün ismi 
-- select top 1
-- p.ProductName,
-- p.UnitPrice
-- from Products p 
-- order by p.UnitPrice desc


--ülkeye göre müşteri sayıları
-- select
-- count(CustomerID) as [Müşteri Sayısı],
-- c.Country as [Ülke]
-- from customers c 
-- group by  c.Country 
-- order by count(CustomerID) desc

--stoğu 20 ile 50 arasında olan ürünler 
-- select
-- p.ProductName ,
-- p.UnitsInStock
-- from Products p 
-- where p.UnitsInStock between  20 and 50 
-- order by p.UnitsInStock 
     
--Hangi ürün Hangi Kategori

select
p.ProductName as [Ürün],
c.CategoryName
from Products p join Categories c on p.CategoryID=c.CategoryID