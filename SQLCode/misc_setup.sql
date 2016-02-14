
CREATE TABLE Customers
(CustomerID INT NOT NULL PRIMARY KEY
, CustomerName VARCHAR(200) NOT NULL
, CreditAuthorizedUser VARCHAR(200) COLLATE Latin1_General_BIN2 
                  ENCRYPTED WITH
                     ( 
                          ENCRYPTION_TYPE = DETERMINISTIC, 
                          ALGORITHM = 'AEAD_AES_256_CBC_HMAC_SHA_256', 
                          COLUMN_ENCRYPTION_KEY = CustomerAuthCert
                          )
				    NOT NULL 
, CreditLimit MONEY NOT NULL DEFAULT 0.0
, SecureCreditLimit NUMERIC(10,4) NOT NULL 
, Active BIT NOT NULL DEFAULT 1
);
GO
CREATE PROCEDURE Customers_Insert
  @CustomerID INT
, @CustomerName VARCHAR(200)
, @CreditAuthorizedUser VARCHAR(200)
, @CreditLimit MONEY
, @Active bit
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

EXEC dbo.Customers_Insert
   @customerid = 3
 , @CustomerName = 'Starfleet Supply'
 , @CreditAuthorizedUser = 'James T. Kirk'
 , @CreditLimit = 88
 , @Active = 1 -- tinyint



EXEC dbo.Customers_SelectOne
  @customerid = 1
GO
 

EXEC dbo.Customers_SelectAll
GO

CREATE ROLE AERights;
GO

GRANT EXECUTE ON dbo.Customers_Insert TO AERights
GRANT EXECUTE ON dbo.Customers_SelectOne TO AERights
GRANT EXECUTE ON dbo.Customers_SelectAll TO AERights
go
ALTER ROLE AERights ADD MEMBER aeuser
go
GRANT VIEW ANY COLUMN MASTER KEY DEFINITION TO AERights;
GO
GRANT VIEW ANY COLUMN ENCRYPTION KEY DEFINITION TO AERights;
go

/*
-- Reset

drop table Customers
drop procedure dbo.Customers_Insert
drop procedure dbo.Customers_SelectOne
drop procedure dbo.Customers_SelectAll


-- SSMS
Column Encryption Setting = Enabled


*/ 			   
			   