CREATE TABLE Categories
(
	Id INT PRIMARY KEY,
	Category_name NVARCHAR(20)
)

CREATE TABLE Products
(
	Id INT PRIMARY KEY,
	Product_name NVARCHAR(20)
)

INSERT INTO Categories VALUES
(1, 'drinks'),
(2, 'sweets'),
(3, 'bakery'),
(4, 'meat'),
(5, 'alcohol')

INSERT INTO Products VALUES
(1, 'water'),
(2, 'cola'),
(3, 'cookie'),
(4, 'steak'),
(5, 'bread'),
(6, 'pie'),
(7, 'candies'),
(8, 'whiskey'),
(9, 'beer'),
(10, 'soap')

CREATE TABLE Category_Product (
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	PRIMARY KEY (CategoryId, ProductId)
);

INSERT INTO Category_Product VALUES
(1, 1),
(1, 2),
(1, 8),
(1, 9),
(2, 3),
(2, 6),
(2, 7),
(3, 3),
(3, 5),
(3, 6),
(4, 4),
(5, 8),
(5, 9)