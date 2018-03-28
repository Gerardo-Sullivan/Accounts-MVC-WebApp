--Purchase Table
--Author: Gerardo Sullivan
--Date: 27/03/18
CREATE TABLE Purchase (
	PurchaseID INT IDENTITY(1,1) PRIMARY KEY,
	AccountID int,
	ProductName VARCHAR(35),
	PurchaseDate DATETIME, 
	FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);