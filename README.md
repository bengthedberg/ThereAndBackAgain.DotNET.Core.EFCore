**.NET Core Entity Framework - *There And Back Again***

This repository contains several branches, each with some changes implementing different features of using .NET Core Entity Framework in a ASP.NET Core MVC application.

**Step 1 - Create the project**

Create a local folder:

```mkdir InstantScratchIts```

and in that folder a solution file:

```dotnet new sln --name InstantScratchIts```

Create an ASP.NET Core MVC project:

``` dotnet new mvc --name InstantScratchIts.Web --output InstantScratchIts.Web```

and add it to the solution:

```dotnet sln add .\InstantScratchIts.Web\InstantScratchIts.Web.csproj```

That's it! Let's build and run the project to ensure that it all works:

```dotnet build```

```dotnet run -p .\InstantScratchIts.Web\InstantScratchIts.Web.csproj```

**Step 2 - Add Entity Framework Core**

In this step we will :

* choose a database provider, i.e SQL Server, Postgres or similar. See [list of providers](https://docs.microsoft.com/en-us/ef/core/providers/) for every option.
* add the EF Core NuGet packages
* configure the database connection string
* setup the [DBContext](https://github.com/bengthedberg/EntityFrameworkCore/blob/master/src/EFCore/DbContext.cs). You use the DbContext in your application to both
  configure EF Core and to access the database at runtime.



We will use SQL Server as the database provider so we need to add the Microsoft.EntityFrameworkCore.SqlServer NuGet package.

``` dotnet add .\InstantScratchIts.Web\InstantScratchIts.Web.csproj package Microsoft.EntityFrameworkCore.SqlServer```

We will also add the Microsoft.EntityFrameworkCore.Tools NuGet package as this will allow us to create and update your database from the command line.



We will add the database connection string to the application settings file. In this example we will just use the localdb as default. 
```"Server=(localdb)\\mssqllocaldb;Database=instant;Trusted_Connection=True;MultipleActiveResultSets=true"```



Finally we register the AppDbContext in the ConfigureServices method of Startup.cs.
EF Core provides a generic AddDbContext<T> extension method for this purpose,
which takes a configuration function for a [DbContextOptionsBuilder ](https://docs.microsoft.com/en-us/ef/core/providers/). This
builder can be used to set a host of internal properties of EF Core and lets you completely
replace the internal services of EF Core if you want.

Finish up with a rinse and repeat, i.e build and run :

```dotnet build```

```dotnet run -p .\InstantScratchIts.Web\InstantScratchIts.Web.csproj```

**Step 3 - Create a database schema**

Create the schema by creating your POCO classes and register them with the DBSet 

In this case we have instant scratch it game that is valid in one or more jurisdictions. 

