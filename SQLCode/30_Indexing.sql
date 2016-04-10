/*
End to End Always Encrypted - indexing

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/
USE AlwaysEncryptedDemo
GO

-- Determinism
-- Add another email - sjones@myisp.net
-- Add another email - andy@someisp.com


-- Include Actual Execution Plan
-- View the data
EXEC dbo.Customers_SelectAll;
GO



-- create an index
CREATE INDEX Customer_Email_IDX
 ON dbo.Customers (CustomerEmail);
GO


-- Works



-- New index
CREATE INDEX Cutomer_Secure_IDX
 ON dbo.Customers(SecureCreditLimit);
 GO
-- Not valid
 
