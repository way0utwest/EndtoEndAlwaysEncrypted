/*
End to End Always Encrypted - Key Rotation

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/
USE AlwaysEncryptedDemo
GO

-- Run ISE
-- Create new cert


-- create new CMK
CREATE COLUMN MASTER KEY NewCMK
WITH (
KEY_STORE_PROVIDER_NAME = N'MSSQL_CERTIFICATE_STORE',
KEY_PATH = N'CurrentUser/My/D036738E24980F766D2D0800B26DF09858FDDE66'
);

-- encrypt CeK
