--Select 
--ANSII oracle postsql çalışır
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

--Şehir bilgisi 'Berlin' olan müşterileri göster.
Select * from Customers where City = 'Berlin'

--case insensitive - büüyk küçük harf duyarsız
select * from Products where categoryId=1 or categoryId=3

select * from Products where categoryId=1 and UnitPrice>=10

--order by: sıralama
select * from Products where categoryId=1 order by UnitPrice desc   --descending - Azalan,düşen 

--Sayaç
select count(*) from Products  

--Hangi kategoride kaç farklı ürün var?
select categoryID,count(*) from products group by CategoryID

--İçerisinde 10dan az olan kategorideki ürünleri göster !
select categoryID,count(*) from products group by CategoryID having count(*)<10

--Sayısı 10dan az olan satış fiyatı 20'den fazla olanların kategorileri ve adedi.
select categoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

-- ürünler ve kategorileri birleştir. -neye göre birleştirilecek.
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID 
where Products.UnitPrice>10

--DTO DAtA Transformation Object

--Solda olup sağda olmayanlarıda getirir.
select * from Products p left join [Order Details] od 
on p.ProductID = od.ProductID

--müşteri olacak ama hiç sipariş vermeiş olacaklar. Yenimüşteriler ! sana özel %10 indirim yeni üyesin.
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null


--Birden fazla inner kullanmak.
select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID


