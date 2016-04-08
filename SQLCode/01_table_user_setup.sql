/*
End to End Always Encrypted - Setup

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/
USE AlwaysEncryptedDemo;
GO

-- Create the Column Master Key
CREATE COLUMN MASTER KEY [EndtoEndAEKey]
WITH
(
	KEY_STORE_PROVIDER_NAME = N'MSSQL_CERTIFICATE_STORE',
	KEY_PATH = N'CurrentUser/My/603009ABF0050AABD273B77E9BB6B0269C566906'
)
GO


-- Create the Column Encryption Key
CREATE COLUMN ENCRYPTION KEY [AEDemoCEK]
WITH VALUES
(
	COLUMN_MASTER_KEY = [EndtoEndAEKey],
	ALGORITHM = 'RSA_OAEP',
	ENCRYPTED_VALUE = 0x016E008000630075007200720065006E00740075007300650072002F006D0079002F003600300033003000300039006100620066003000300035003000610061006200640032003700330062003700370065003900620062003600620030003200360039006300350036003600390030003600995E414D8024078D8128CA01929F3513DA02163B79533A91CCFC735BF7C60B9E487C2A821BF486D2BE78CD953D22C6D3DDEB08BB209742D4BA5DB9E57E70478343E620A8984B3886F15101979654A946B107F1A9DC41A43009D86CCF98EE7A4EB06370168C3162C9129E0D34A6E63D598664E18C852F3E351E05F53F728169BC9BD83B87A300092A8CB891C15391317F9971963802EC0A3A51CBF6859BCEA69682AA86E185E52508957581B1E579EB54298448778AD39B11685686CD2C2B67CC4F7419774062CC9C955D4C5D7B362248297CAFA3A41151116E13E6501839B1DF1B62E483138FAFE3530B31F0729AB0A310FDFC3D0A5D620CF8D947A7CF8B9668
)

GO

-- Create the table with data
CREATE TABLE Customers
(CustomerID INT NOT NULL PRIMARY KEY
, CustomerName VARCHAR(200) NOT NULL
, CustomerEmail VARCHAR(200) COLLATE Latin1_General_BIN2 
, TaxID VARCHAR(20) NOT NULL
, CreditLimit MONEY NOT NULL DEFAULT 0.0
, SecureCreditLimit Money NOT NULL 
, Active BIT NOT NULL DEFAULT 1
);
GO
DROP PROCEDURE IF EXISTS dbo.Customers_Insert;
DROP PROCEDURE IF EXISTS dbo.Customers_SelectAll;
DROP PROCEDURE IF EXISTS dbo.Customers_SelectOne;

GO

/*
Insert data
*/
INSERT customers 
 VALUES (1, 'Steve', 'sjones@myisp.net', '1234567', 100, 200, 1)
      , (2, 'Andy', 'andy@someisp.com', '45667778', 400, 2000, 1)
      , (3, 'Kyle', 'kylejohnson@hotmail.com', '9876765765', 200, 2000, 1)
      , (4, 'DJ', 'dj@halo.com', '55555555', 3500, 20000, 1)
      , (5, 'Sarah', 'ssmith@gmail.com', '4666688', 4000, 20000, 1)
GO

/*
Create a few procedures to work with the table.
*/

CREATE PROCEDURE Customers_Insert
  @CustomerID INT
, @CustomerName VARCHAR(200)
, @CustomerEmail VARCHAR(200)
, @TaxID VARCHAR(20)
, @CreditLimit MONEY
, @SecureCreditLimit MONEY
, @Active BIT
AS
  BEGIN

    INSERT dbo.Customers
        (
          CustomerID
        , CustomerName
        , CustomerEmail
		, TaxID
        , CreditLimit
        , SecureCreditLimit
        , Active
        )
      VALUES
        (
          @CustomerID
        , @CustomerName
        , @CustomerEmail
		, @TaxID
        , @CreditLimit
        , @SecureCreditLimit
        , @Active
        )

  END

GO
CREATE PROCEDURE Customers_SelectOne
-- alter PROCEDURE Customers_SelectOne
 @CustomerEmail VARCHAR(200)
AS
  BEGIN
    SELECT
        *
      FROM
        dbo.Customers AS c
      WHERE
        c.CustomerEmail = @CustomerEmail
  END
GO

CREATE PROCEDURE Customers_SelectAll
AS
  BEGIN
    SELECT
        *
      FROM
        dbo.Customers AS c
  END
 GO

 
-- Security setup
-- Create a role and grant rights
CREATE ROLE AERights;
GO
GRANT EXECUTE ON dbo.Customers_Insert TO AERights
GRANT EXECUTE ON dbo.Customers_SelectOne TO AERights
GRANT EXECUTE ON dbo.Customers_SelectAll TO AERights
GO
-- Add our user
CREATE USER AEUSer FOR LOGIN AEUser;
GO

ALTER ROLE AERights ADD MEMBER aeuser
GO




-- Need to grant security for the encryption keys
GRANT VIEW ANY COLUMN MASTER KEY DEFINITION TO AERights;
GO
GRANT VIEW ANY COLUMN ENCRYPTION KEY DEFINITION TO AERights;
GO

/*
-- Reset

drop table Customers
drop procedure dbo.Customers_Insert
drop procedure dbo.Customers_SelectOne
drop procedure dbo.Customers_SelectAll


-- SSMS
Column Encryption Setting = Enabled


*/ 			   
			   