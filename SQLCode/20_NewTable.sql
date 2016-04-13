/*
End to End Always Encrypted - Setup from Scratch

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/

-- Show new certificate
-- run ISE, with Generate_New_Certificate.ps1
-- Check User store
-- Get Thumbprint, replace below

CREATE COLUMN MASTER KEY SteveDemoNewCMK
WITH (
KEY_STORE_PROVIDER_NAME = N'MSSQL_CERTIFICATE_STORE',
KEY_PATH = N'CurrentUser/My/1B5DDF79C12CE64A2AF514D2E78E2B40B4EA61A9'
);
GO


-- Need a new CEK
-- USE GUI, save script, name SteveCEK2





-- Create a new table from scratch.

CREATE TABLE Customers2
(CustomerID INT NOT NULL PRIMARY KEY
, CustomerName VARCHAR(200) NOT NULL
, CustomerEmail VARCHAR(200) COLLATE Latin1_General_BIN2 
                  ENCRYPTED WITH
                     ( 
                          ENCRYPTION_TYPE = DETERMINISTIC, 
                          ALGORITHM = 'AEAD_AES_256_CBC_HMAC_SHA_256', 
                          COLUMN_ENCRYPTION_KEY = [SteveCEK2]
                          )
				    NOT NULL 
, TaxID VARCHAR(20) NOT NULL
, CreditLimit MONEY NOT NULL DEFAULT 0.0
, SecureCreditLimit Money NOT NULL 
, Active BIT NOT NULL DEFAULT 1
);
GO


-- load data?
INSERT dbo.Customers2
 SELECT *
 FROM dbo.Customers AS c
GO


-- alter the stored procedures to look at this value
-- Execute these two only
ALTER PROCEDURE Customers_SelectAll
AS
  BEGIN
    SELECT
        *
      FROM
        dbo.Customers2 AS c
  END
 GO


 ALTER PROCEDURE Customers_SelectOne
 @CustomerEmail VARCHAR(200)
AS
  BEGIN
    SELECT
        *
      FROM
        dbo.Customers2 AS c
      WHERE
        c.CustomerEmail >= @CustomerEmail
  END
GO
-----------------------------------------





-- Try this
 ALTER PROCEDURE Customers_SelectOne
 @CustomerEmail VARCHAR(200)
AS
  BEGIN
    SELECT
        *
      FROM
        dbo.Customers2 AS c
      WHERE
        c.CustomerEmail = @CustomerEmail
  END
GO
