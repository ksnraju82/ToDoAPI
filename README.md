# ToDoAPI
The app was developed in .net core 3.0 

Install necessary NuGet packages
Add the following NuGet packages to work with SQL Server database and scaffolding, and run the following commands in Package Manager Console (Click Tools -> NuGet Package Manager ->  Package Manager Console).

This package helps generate controllers and views.

Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design -Version 3.0.0
This package helps create database context and model classes from the database.

Install-Package Microsoft.EntityFrameworkCore.Tools -Version 3.0.0
Database provider allows Entity Framework Core to work with SQL Server.

Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.0.0
It provides support for creating and validating a JWT token.

Install-Package IdentityModel.Tokens.Jwt -Version 5.6.0
This is the middleware that enables an ASP.NET Core application to receive a bearer token in the request pipeline.

Install-Package Microsoft.AspNetCore.Authentication.JwtBearer -Version 3.0.0

Create necessary db scripts :

--Create Table UserInfo(
--UserId Int Identity(1,1) Not null Primary Key,
--FirstName Varchar(30) Not null,
--LastName Varchar(30) Not null,
--UserName Varchar(30) Not null,
--Email Varchar(50) Not null,
--Password Varchar(20) Not null,
--CreatedDate DateTime Default(GetDate()) Not Null)
--GO
--Insert Into UserInfo(FirstName, LastName, UserName, Email, Password) 
--Values ('TaskManager', 'Admin', 'TaskManagerAdmin', 'test@test.com', 'test@123')

--Create Table Scheduler(
--TaskID Int Identity(1,1) Primary Key,
--[Name] Varchar(100) Not Null,
--[Priority] INT,
--CreatedDate DateTime Default(GetDate()) Not Null)
--GO
--Insert Into Scheduler([Name], [Priority]) 
--Values ('TEST1', 1)
