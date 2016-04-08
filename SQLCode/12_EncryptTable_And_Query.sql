/*
End to End Always Encrypted - Encrypting data

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/


-- Use the SSMS wizard at first.
-- Encrypt CustomerEmail with deterministic encryption
-- Encrypt SecureCreditLimit with random.

-- Query
EXEC dbo.Customers_SelectAll;
GO

-- If this works, check connection settings
-- Need Column Encryption Setting = Enabled in additional parameters




-- Let's add a row
 EXEC dbo.Customers_Insert
   @customerid = 12
 , @CustomerName = 'RoadRunner'
 , @CustomerEmail = 'wiley@coyote.com'
 , @TaxID = '000000001'
 , @CreditLimit = 9999
 , @SecureCreditLimit = 9999
 , @Active = 1 -- tinyint;



-- Error
-- Why?

-- Inserts must be with 