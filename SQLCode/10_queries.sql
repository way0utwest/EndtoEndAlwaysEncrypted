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


 EXEC dbo.Customers_Insert
   @customerid = 1
 , @CustomerName = 'Acme'
 , @CreditAuthorizedUser = 'Bill'
 , @TaxID = '123456'
 , @CreditLimit = 5000
 , @SecureCreditLimit = 20000
 , @Active = 1 -- tinyint;


EXEC dbo.Customers_Insert
   @customerid = 2
 , @CustomerName = 'RoadRunner Enterprises'
 , @CreditAuthorizedUser = 'Wile E. Coyote'
 , @TaxID = '789012'
 , @CreditLimit = 500
 , @Active = 1 -- tinyint

EXEC dbo.Customers_Insert
   @customerid = 3
 , @CustomerName = 'Starfleet Supply'
 , @CreditAuthorizedUser = 'James T. Kirk'
 , @TaxID = '987654321'
 , @CreditLimit = 88
 , @Active = 1 -- tinyint
 GO


-- Try SELECT queries
EXEC dbo.Customers_SelectOne
  @customerid = 1
GO
 

EXEC dbo.Customers_SelectAll
GO
