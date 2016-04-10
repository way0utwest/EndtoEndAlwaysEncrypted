/*
End to End Always Encrypted - Encrypting data

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/


-- Use the SSMS wizard at first.
-- Create encryption Keys

-- Encrypt CustomerEmail with deterministic encryption
-- Encrypt SecureCreditLimit with random.


USE AlwaysEncryptedDemo
GO

-- Query
EXEC dbo.Customers_SelectAll;
GO

-- If this works, check connection settings
-- Need Column Encryption Setting = Enabled in additional parameters


EXEC dbo.Customers_SelectOne
  @CustomerEmail = 'andy@someisp.com'
GO

-- What about parameters?
DECLARE @e VARCHAR(200) = 'andy@someisp.com';
EXEC dbo.Customers_SelectOne
  @CustomerEmail = @e;
GO




-- Let's add a row
 EXEC dbo.Customers_Insert
   @customerid = 12
 , @CustomerName = 'RoadRunner'
 , @CustomerEmail = 'andy@someisp.com'
 , @TaxID = '000000001'
 , @CreditLimit = 100
 , @SecureCreditLimit = 200
 , @Active = 1 -- tinyint;



-- Error
-- Why?

-- Inserts must be with parameters matching the data type and precision.


