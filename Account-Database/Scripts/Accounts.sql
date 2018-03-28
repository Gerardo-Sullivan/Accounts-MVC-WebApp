--Accounts Table
--Author: Gerardo Sullivan
--Date: 27/03/18
CREATE TABLE Accounts (
	AccountID INT IDENTITY(1,1) PRIMARY KEY,
	LastName VARCHAR(35) NOT NULL,
	FirstName VARCHAR(35) NOT NULL,
	Address VARCHAR(255) NOT NULL,
	Country VARCHAR(35) NOT NULL,
	Email VARCHAR(255) NOT NULL,
	Age INT,
);