Create database Sam_Store
go
use Sam_Store
go
Create table dbo.Category(Id int primary key identity(1,1),Code int,Title nvarchar(30))
go
Create table dbo.Product(Id int primary key identity(1,1),Code int,CategoryRef int,Title nvarchar(30),Quantity int,UnitPrice int)

select*from dbo.Category
insert into dbo.Category(Code,Title) values (12,'LapTop')