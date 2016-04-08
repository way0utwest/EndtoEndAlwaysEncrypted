/*
End to End Always Encrypted - Setup from Scratch

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/

CREATE TABLE Customers
(CustomerID INT NOT NULL PRIMARY KEY
, CustomerName VARCHAR(200) NOT NULL
, CustomerEmail VARCHAR(200) COLLATE Latin1_General_BIN2 
                  ENCRYPTED WITH
                     ( 
                          ENCRYPTION_TYPE = DETERMINISTIC, 
                          ALGORITHM = 'AEAD_AES_256_CBC_HMAC_SHA_256', 
                          COLUMN_ENCRYPTION_KEY = [AEDemoCEK]
                          )
				    NOT NULL 
, TaxID VARCHAR(20) NOT NULL
, CreditLimit MONEY NOT NULL DEFAULT 0.0
, SecureCreditLimit Money NOT NULL 
, Active BIT NOT NULL DEFAULT 1
);
GO