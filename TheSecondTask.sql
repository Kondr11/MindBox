SELECT Products.Name + " - " + t2.Name
From Products
LEFT JOIN (SELECT Categories.Name, ProductsCategories.ProductId
FROM Categories INNER JOIN ProductsCategories
ON Categories.Id = ProductsCategories.CategoryId) AS t2
ON t2.ProductId = Products.Id;