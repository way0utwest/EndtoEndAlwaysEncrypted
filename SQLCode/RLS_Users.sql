/*

End to End Encryption - RLS Demo

*/

/*
Login and user setup. 
There are 2 logins and users for basic RLS functionality
There are 3 salespeople users to demonstrate how users can see limited data

create login RLSUser -- normal pwd

Create login RLSMgr -- normal pwd
*/
create login sjones with password = 'Enterapwd', 
create login bsmith
create login kjohnson



use EncryptionDemo
go
create user RLSUser for login
create user sjones for login
create user kjohnson for login
go
alter role SalesUsers add member sjones
alter role SalesUsers add member bsmith
alter role SalesUsers add member kjohnson
go


/*
The security predicate function is used to determine if a user can access particular rows of data.
*/
create function dbo.RLS_SalesPerson_OrderCheck (@salespersonid int)
returns table
with schemabinding
as
return select 1 as [RLS_SalesPerson_OrderCheck_Result]
       from dbo.salespeople sp
	   where (@salespersonid = sp.salespersonid or sp.IsManager = 1)
	   and user_name() = sp.username


/*
The security policy maps the function to a particular table. 
*/
create security policy dbo.RLS_SalesPeople_Orders_Policy
add filter predicate dbo.RLS_SalesPerson_OrderCheck(salespersonid)
on dbo.OrderHeader


setuser 'sjones'
go
select * from OrderHeader
go
setuser
go
select * from OrderHeader


select IS_SRVROLEMEMBER('sysadmin')
