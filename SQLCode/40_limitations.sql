/*
End to End Always Encrypted - Inequalities

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/
USE AlwaysEncryptedDemo
GO



-- Normal query
SELECT CustomerID
 FROM dbo.Customers
 WHERE CustomerID > 3;
 GO




-- Let's query the encrypted column 
SELECT *
 FROM dbo.Customers
  WHERE CustomerEmail > 'sjones'
GO


SELECT *
 FROM dbo.Customers
  WHERE CustomerEmail = 'sjones@myisp.net'
GO

-- error

-- try from the app
-- alter the procedure first
ALTER PROCEDURE Customers_SelectOne
 @CustomerEmail VARCHAR(200)
AS
  BEGIN
    SELECT
        *
      FROM
        dbo.Customers AS c
      WHERE
        c.CustomerID > 3
  END
GO

-- query, a few rows.


-- Now change the proc
ALTER PROCEDURE Customers_SelectOne
 @CustomerEmail VARCHAR(200)
AS
  BEGIN
    SELECT
        *
      FROM
        dbo.Customers AS c
      WHERE
        c.CustomerEmail > @CustomerEmail
  END
GO


-- error
