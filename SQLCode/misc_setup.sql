CREATE TABLE Customers
(CustomerID INT
, CustomerName VARCHAR(200)
, CreditAuthorizedUser VARCHAR(200)
, CreditLimit MONEY
, Active TINYINT
);
GO
CREATE PROCEDURE Customers_Insert
  @customerid INT
, @CustomerName VARCHAR(200)
, @CreditAuthorizedUser VARCHAR(200)
, @CreditLimit MONEY
, @Active TINYINT
AS
BEGIN

INSERT dbo.Customers
    (
      CustomerID
    , CustomerName
    , CreditAuthorizedUser
    , CreditLimit
    , Active
    )
  VALUES
    (
      @customerid
    , @CustomerName
    , @CreditAuthorizedUser
    , @CreditLimit
    , @Active
    )

END

go
CREATE PROCEDURE Customers_SelectOne
  @customerid int
AS
 BEGIN
SELECT * FROM dbo.Customers AS c
WHERE c.CustomerID = @customerid
 END
 GO
CREATE PROCEDURE Customers_SelectAll
AS
 BEGIN
SELECT * FROM dbo.Customers AS c
 END
 GO



 EXEC dbo.Customers_Insert
   @customerid = 1
 , -- int
   @CustomerName = 'Acme'
 , -- varchar(200)
   @CreditAuthorizedUser = 'Bill Smith'
 , -- varchar(200)
   @CreditLimit = 500000
 , -- money
   @Active = 1 -- tinyint


EXEC dbo.Customers_Insert
   @customerid = 2
 , -- int
   @CustomerName = 'RoadRunner Enterprises'
 , -- varchar(200)
   @CreditAuthorizedUser = 'Wile E. Coyote'
 , -- varchar(200)
   @CreditLimit = 500
 , -- money
   @Active = 1 -- tinyint


EXEC dbo.Customers_SelectOne
  @customerid = 1
 

 GRANT EXECUTE ON dbo.Customers_Insert TO AERights
 GRANT EXECUTE ON dbo.Customers_SelectOne TO AERights
 GRANT EXECUTE ON dbo.Customers_SelectAll TO AERights

 sp_who2

 