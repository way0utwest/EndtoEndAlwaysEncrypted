/*
End to End Always Encrypted - Database Setup

Steve Jones, copyright 2016

This code is provided as is for demonstration purposes. It may not be suitable for
your environment. Please test this on your own systems. This code may not be republished 
or redistributed by anyone without permission.
You are free to use this code inside of your own organization.
*/
IF NOT EXISTS( SELECT name FROM sys.databases WHERE name = 'AlwaysEncryptedDemo')
  CREATE DATABASE AlwaysEncryptedDemo
GO
