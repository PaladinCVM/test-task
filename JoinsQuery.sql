SELECT Products."Product_name", Categories."Category_name"
FROM Products
LEFT JOIN Category_Product
	ON Products.Id = Category_Product.ProductId
LEFT JOIN Categories 
	ON Category_Product.CategoryId = Categories.Id;