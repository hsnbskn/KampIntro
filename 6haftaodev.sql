
--6.Hafta Ödevi
SELECT ProductName UrunAdi,
SUM([Order Details].Quantity*[Order Details].UnitPrice) AS KazanilanToplamMiktar
FROM Products JOIN [Order Details] ON Products.ProductID=[Order Details].ProductID
GROUP BY ProductName
ORDER BY KazanilanToplamMiktar ASC;

