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





