--select * from Categories --yıldız yazdığında tüm cloumnları getirir

--select CategoryName , Description from Categories --sadece istediğimiz columnlar

--Products tablosundaki tüm kayıtların ProductID, Price, UnitsInStock, UnitPrice 
--kolonlarını geri döndürün.

--önce bütün kolonları tanıtmak için yıldızlı versiyonla yazıp sonrasında 
--p gibi bir kısaltma isim verip
--sonra p. column isimleri ile çekmek daha kolaylaştırır.
-- columnların ismini değiştirmek için aşağıdaki gibi as ya da köşeli parantez kullanılır.
-- select
--  p.ProductID AS Id, 
-- p.ProductName AS 'Ürün Adı', 
-- p.UnitsInStock [Stok Adedi], 
-- p.UnitPrice AS 'Birim Fiyat' 
-- from Products p


--En yüksek fiyatı bulalım. count fonksiyonu eğer bir satırın içi doluysa sayar yoksa saymaz.
-- select
--     MAX(p.UnitPrice) as [Maksimum Fiyat],
--     MIN(p.UnitPrice) as [Minimum Fiyat],
--     AVG(p.UnitPrice) as [Ortalama],
--     count(*) as [Ürün Sayısı],
--     SUM(p.UnitPrice * p.UnitsInStock) as [Toplam Değer]
-- from Products p

--temel fonksiyon 
-- Select 
-- p.ProductName As [Default],
-- UPPER(p.ProductName) as [BÜYÜK HARF],
-- LOWER(p.ProductName) as [KÜÇÜK HARF],
-- LOWER(REPLACE((REPLACE(p.ProductName,' ','_')), '?','')) as [Url]
-- from Products p

-- Select *
-- from Products p 
-- WHERE p.UnitPrice >40

-- select *
-- from Products p
-- -- where p.UnitPrice >=40 and p.UnitPrice<=100
-- where p.UnitPrice between 40 and 100 
-- -- ORder by p.CategoryID desc --azalan sıralama için desc yazcaksın asc de defaulttur artan.
-- ORder by p.CategoryID , p.UnitPrice desc


--joini sqlde tabloları ilişkili alanları tablolar üzrinde birleştirme işlemine join denir 

--Join türleri :
--(inner) join: Birleştirilecek iki tablodaki eşleşen kayıtları bir araya getirir.

--left join: Sol taraftaki tablonun tüm kayıtlarını sağdaki tablonun ise sadece eşleşen kayıtlarını getiri.

--right join: Sağ taraftaki tablonun tüm kayıtlarını soldaki tablonun ise sadece eşleşen kayıtlarını getiri.

--outer (full) join: Birleştirilecek iki tablodaki eşleşen ya da eşleşmeyen tüm kayıtları bir araya getirir.

--Product ve Categories tablolarının birleştirilmesini sağlayalım

-- select 
--     p.ProductID as [Id],
--     p.ProductName as [Ürün],
--     p.UnitPrice as [Fiyat],
--     c.CategoryName as [Kategori]
-- from Products p JOIN Categories c on c.CategoryID = p.CategoryID
-- where c.CategoryName = 'Beverages'

--Yeni bir kategori ekliyoruz

-- Insert Into Categories(CategoryName, Description)
-- Values ('Televizyon','Televizyon Ürünleri Burada')

-- select *
-- from Categories c  right join  Products p on p.CategoryID = c.CategoryID

--ürünleri (productId , ProductName, UnitPrice ) Supplier Company Nameleri ile birlikte listeleyelim.

-- select
-- p.ProductID as [Id],
-- p.ProductName as [ürün],
-- p.UnitPrice as [Fiyat],
-- s.CompanyName as [Tedarikçi]
-- FROM Products p 
--         JOIN Suppliers s 
--     on p.SupplierID = s.SupplierID
-- order by [Tedarikçi]

--ürünleri (productId , ProductName, UnitPrice ) CategoryName ve Supplier Company Nameleri ile birlikte listeleyelim.

-- select
-- p.ProductID as [Id],
-- p.ProductName as [ürün],
-- p.UnitPrice as [Fiyat],
-- s.CompanyName as [Tedarikçi],
-- c.CategoryName as [Kategori]
-- FROM Products p 
--         JOIN Suppliers s 
--     on p.SupplierID = s.SupplierID 
--         join Categories c 
--     on p.CategoryID = c.CategoryID
-- order by [Kategori], [Tedarikçi]

--HAngi sipariş hangi çalışan tarafından hangi müşteriye gerçekleştirildi.
-- order ıd,order date, employee name , customer NAme 

-- select
-- o.OrderID as [Sipariş No],
-- o.OrderDate as [sipariş tarihi],
-- (e.FirstName + ' '+  e.LastName) as [Çalışan],
-- c.CompanyName as [Müşteri]
-- from Orders o join employees e on o.EmployeeID =e.EmployeeID 
--             join Customers c on o.CustomerID=c.CustomerID

--Kategoriye göre ürün stok adedini gösteelim 

-- select
-- c.CategoryName as [Kategori],
-- sum(p.UnitsInStock) as [Stok Miktarı]
-- from Products p join Categories c on p.CategoryID=c.CategoryID 
-- group by c.CategoryName

--hangi ülkede kaç müşterim var 

-- select
-- c.Country as [Ülke],
-- Count(*) as [Müşteri Sayısı]
-- from Customers c 
-- group by c.Country
-- Order by [Müşteri Sayısı] desc 

--EN çok hangi ülkede müşterimiz varsa müşteri sayısıyla birlikte gösterelim.

-- select TOP(1)
-- c.Country as [Ülke],
-- Count(*) as [Müşteri Sayısı]
-- from Customers c 
-- group by c.Country
-- Order by [Müşteri Sayısı] desc 

-- Hangi kategoride kaç adet ürün var 

-- select 
-- c.CategoryName as [Kategori],
-- COUNT(p.ProductID) as [Adet] 
-- from  Products p right join Categories c on c.CategoryID =p.CategoryID
-- group by c.CategoryName 


--Hangi Ülkeye ne kadarlık kargo harcaması yapmışız 
-- select 
-- o.ShipCountry as [Ülke],
-- Sum(o.Freight) as [Kargo Harcaması]
-- from Orders o 
-- group by o.ShipCountry  

--HAngi ülkelere satış yapmışız
-- select DISTINCT ShipCountry from Orders

--Hangi ülkeye ne kadarlık Satış Yapmışız



-- select
-- o.ShipCountry as [Ülke],
-- sum(d.UnitPrice*d.Quantity*(1-d.Discount)) as [Tutar]
-- from Orders o join OrderDetails d on o.OrderID = d.OrderID
-- group by o.ShipCountry
-- order by [Tutar] desc
--tutar kolonunda görüntülenen  sayının 18.810,05 olarak görünmesi için ne yapmalıyız?

--Germany'den tedarik edilen ürünlerin toplam satış tutarı bulunuz. 

-- select
-- c.CategoryName as [Kategori], 
-- sum(od.UnitPrice*od.Quantity*(1-od.Discount)) as [Tutar]
-- from  OrderDetails od join Products p on od.ProductID=p.ProductID
--                     join suppliers s on s.SupplierID=p.SupplierID
--                     join Categories c on p.CategoryID=c.CategoryID
--                     where s.Country='Germany' 
--                     group by c.CategoryName
--                     HAVING sum(od.UnitPrice*od.Quantity*(1-od.Discount)) >20000  
--                     order by [Tutar] desc

--Bölgelere göre satış tutarı 

-- select
-- r.RegionDescription as [Bölgeler],
-- FORMAT(sum(od.UnitPrice*od.Quantity*(1-od.Discount)),'N2','tr-TR') as [Tutar]
-- from OrderDetails od Join Orders o on od.OrderID = o.OrderID
--     join Employees e on o.EmployeeID=e.EmployeeID
--         join EmployeeTerritories et on e.EmployeeID=et.EmployeeID
--             join Territories t on et.TerritoryID=t.TerritoryID
--                 join Region r on t.RegionID=r.RegionID 
--     group by r.RegionDescription
--     order by r.RegionDescription

--HAngi Çalışanım ,Hangi kategoriden ne kadarlık sipariş almıştır.

-- select
-- e.FirstName as [Çalışan],
-- c.CategoryName as [Kategori],
-- sum(od.UnitPrice*od.Quantity*(1-od.Discount)) as [Tutar]
-- from Employees e join Orders o on e.EmployeeID=o.EmployeeID
--     join OrderDetails od on o.OrderID=od.OrderID
--         join Products p on p.ProductID=od.ProductID
--             join Categories c on p.CategoryID= c.CategoryID
--     group by e.FirstName , c.CategoryName 
--     order by e.FirstName , c.CategoryName 

-- select
-- cu.CompanyName as [Müşteri],
-- c.CategoryName as [Kategori],
-- sum(od.UnitPrice*od.Quantity*(1-od.Discount)) as [Tutar]
-- from Customers cu join Orders o on cu.CustomerID=o.CustomerID
--     join OrderDetails od on o.OrderID=od.OrderID
--         join Products p on p.ProductID=od.ProductID
--             join Categories c on p.CategoryID= c.CategoryID
--     group by cu.CompanyName , c.CategoryName 
--     order by cu.CompanyName , c.CategoryName 

--1997 yılının mart ayında yapılan siparişleri listeleyelim 
--Chai ürününe ait 1997 yılının mart ayında yapılan satışları listeleyelim

-- select *
-- from Orders o join OrderDetails od on o.OrderID=od.OrderID
--     join Products p on p.ProductID=od.ProductID
-- where o.OrderDate Between '1997-03-1' and '1997-3-31' and p.ProductName ='Chai'


                    

