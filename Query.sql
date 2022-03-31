-- create a table Products
CREATE TABLE Products (
  id INTEGER PRIMARY KEY,
  name TEXT NOT NULL,
  category INTEGER 
);
-- insert values
INSERT INTO Products VALUES (1, 'Apple', 2);
INSERT INTO Products VALUES (2, 'Bred', 1);
INSERT INTO Products VALUES (3, 'Ecler', 1);
INSERT INTO Products VALUES (4, 'Orange', 2);
INSERT INTO Products VALUES (5, 'Paprica', 3);
INSERT INTO Products VALUES (6, 'Chiken', NULL);

-- create a table Products
CREATE TABLE Category (
  id INTEGER PRIMARY KEY,
  name TEXT NOT NULL
);
-- insert values
INSERT INTO Category VALUES (1, 'bakery');
INSERT INTO Category VALUES (2, 'fructs');
INSERT INTO Category VALUES (3, 'flavoring');
-- fetch some values
SELECT Products.name,Category.name FROM Products left JOIN Category
on Category.id = Products.category
