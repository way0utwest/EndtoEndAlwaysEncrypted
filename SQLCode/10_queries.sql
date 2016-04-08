/*
End to End Always Encrypted - Initial Queries and testing

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/
USE AlwaysEncryptedDemo
GO
-- Look at the data
EXEC dbo.Customers_SelectAll
GO


-- Let's add a row
 EXEC dbo.Customers_Insert
   @customerid = 10
 , @CustomerName = 'Acme'
 , @CustomerEmail = 'Bill@bill.com'
 , @TaxID = '12345678990'
 , @CreditLimit = 50
 , @SecureCreditLimit = 50
 , @Active = 1 -- tinyint;


-- requery
EXEC dbo.Customers_SelectAll
GO


-- Try a single one
EXEC dbo.Customers_SelectOne
  @customeremail = 'bill@bill.com'
GO



-- why?




-- collation
EXEC dbo.Customers_SelectOne
  @customeremail = 'Bill@bill.com'
GO

