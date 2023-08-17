use [aspnet-LAP_Skiverleih-fbba795d-e321-4c65-9180-af5558f7bb1b]
DELETE FROM Loans;
DELETE FROM Customers;
DELETE FROM Articles;
DELETE FROM Categories;

SET IDENTITY_INSERT Categories ON;

INSERT INTO Categories(CategoryID, CategoryName) VALUES(1, 'Skies');
INSERT INTO Categories(CategoryID, CategoryName) VALUES(2, 'Snowboards');
INSERT INTO Categories(CategoryID, CategoryName) VALUES(3, 'Equipment');

SET IDENTITY_INSERT Categories OFF;

SET IDENTITY_INSERT Articles ON;

INSERT INTO Articles(ArticleID, Title, CategoryID, PricePerDay, LoanCount, LoanedOut) VALUES(1, 'Sonic Super Ski', 1, 10.00, 1, 0);
INSERT INTO Articles(ArticleID, Title, CategoryID, PricePerDay, LoanCount, LoanedOut) VALUES(2, 'Marios Mushroom Jumper', 1, 15.00, 0, 0);
INSERT INTO Articles(ArticleID, Title, CategoryID, PricePerDay, LoanCount, LoanedOut) VALUES(3, 'Luigis Loveboard', 2, 20.00, 1, 0);
INSERT INTO Articles(ArticleID, Title, CategoryID, PricePerDay, LoanCount, LoanedOut) VALUES(4, 'Bowsers Bowl Board', 2, 18.00, 0, 0);
INSERT INTO Articles(ArticleID, Title, CategoryID, PricePerDay, LoanCount, LoanedOut) VALUES(5, 'Yoshis Yeti Yeezy', 3, 5.00, 0, 0);
INSERT INTO Articles(ArticleID, Title, CategoryID, PricePerDay, LoanCount, LoanedOut) VALUES(6, 'Daisys Avalanche Shovel', 3, 8.00, 0, 0);
INSERT INTO Articles(ArticleID, Title, CategoryID, PricePerDay, LoanCount, LoanedOut) VALUES(7, 'Birdos Beepers Beeps', 3, 4.00, 0, 0);

SET IDENTITY_INSERT Articles OFF;

SET IDENTITY_INSERT Customers ON;

INSERT INTO Customers(CustomerID, FirstName, LastName) VALUES(1, 'Peter', 'Panda');
INSERT INTO Customers(CustomerID, FirstName, LastName) VALUES(2, 'Leo', 'Lion');
INSERT INTO Customers(CustomerID, FirstName, LastName) VALUES(3, 'Oliver', 'Owl');
INSERT INTO Customers(CustomerID, FirstName, LastName) VALUES(4, 'Max', 'Moose');
INSERT INTO Customers(CustomerID, FirstName, LastName) VALUES(5, 'Perry', 'Platapus');

SET IDENTITY_INSERT Customers OFF;

SET IDENTITY_INSERT Loans ON;

INSERT INTO Loans (LoanID, ArticleID, CustomerID, LoanDate, ReturnDate)VALUES (1, 1, 1,'2023-08-15', '2023-08-16');
INSERT INTO Loans (LoanID, ArticleID, CustomerID, LoanDate, ReturnDate)VALUES (2, 3, 1,'2023-08-14', '2023-08-16');

SET IDENTITY_INSERT Loans OFF;