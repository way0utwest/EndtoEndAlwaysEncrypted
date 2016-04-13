/*
End to End Always Encrypted - indexing 2

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/
USE AlwaysEncryptedDemo
GO

-- alter procedure
ALTER PROCEDURE dbo.Customers_SelectOne
 @CustomerEmail VARCHAR(200)
AS
  BEGIN
  DECLARE @limit INT;
  SELECT @limit = CAST( @CustomerEmail AS INT);
    SELECT
        *
      FROM
        dbo.Customers AS c
      WHERE
        c.SecureCreditLimit = @limit
  END
GO


-- Can't alter the procedure



-- direct query
SELECT *
 FROM dbo.Customers
 WHERE SecureCreditLimit = 0x0175D39EE573D997447C7FF32158F23DC7CFF7E8D66D2B52B17E0E9017B0A553F7FDCD0D6CC6202E83E09AE0A2D01D12859ED605F520BACE63B3B604E5FB0F8B53




 -- I can query for other values

ALTER PROCEDURE dbo.Customers_SelectOne
 @CustomerEmail varchar(200)
AS
  BEGIN
  DECLARE @id INT
  SELECT @id = CAST(@customerEmail AS INT);
    SELECT
        *
      FROM
        dbo.Customers AS c
      WHERE
        c.CustomerID = @ID
  END
GO


-- exec 
EXEC dbo.Customers_SelectOne '1';


-- Run app
