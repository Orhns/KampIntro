



SELECT Products.ProductName [Ürün Adı],SUM([Order Details].Quantity*[Order Details].UnitPrice) [Kazanılan Toplam Miktar] FROM [Order Details] 
INNER JOIN Orders ON [Order Details].OrderID = Orders.OrderID 
INNER JOIN Products ON [Order Details].ProductID = Products.ProductID
GROUP BY Products.ProductName ORDER BY [Kazanılan Toplam Miktar] DESC


