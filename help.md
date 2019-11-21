# Command Dotnet CLI

* `dotnet new` – Used to create new projects
* `dotnet run` – Used to run projects
* `dotnet test` – Used to execute test projects and run unit tests
* `dotnet publish` – Used to publish projects
* `dotnet sln add/remove` – Used to add projects to a solution file
* `dotnet add/remove reference` – Used to add project references to another project
* `dotnet add/remove package` – Used to add NuGet package references to a project
* `dotnet new sln -o MyWebApp` - New solution named MyWebApp in new directory
* `dotnet new mvc -o MyWebApp.Client` - New mvc app in new sub-directory
* `dotnet sln MyWebApp.sln add .\MyWebApp.Client\MyWebApp.Client.csproj .\MyWebApp.DataStore\MyWebApp.DataStore.csproj .\MyWebApp.DataStoreTest\MyWebApp.DataStoreTest.csproj` - Add mvc app to solution
* `dotnet new classlib -o MyWebApp.DataStore` - New classlib in new sub-directory
* `dotnet add .\MyWebApp.Client\MyWebApp.Client.csproj reference .\MyWebApp.DataStore\MyWebApp.DataStore.csproj` - Add classlib to solution
* `dotnet new mstest -o MyWebApp.DataStoreTest` - New mstest project in new sub-directory
* `dotnet add .\MyWebApp.DataStoreTest\MyWebApp.DataStoreTest.csproj reference .\MyWebApp.DataStore\MyWebApp.DataStore.csproj` - Add mstest project to solution
* `dotnet test .\MyWebApp.DataStoreTest\MyWebApp.DataStoreTest.csproj` - Run the unit test project
* `dotnet run -p .\MyWebApp.Client\MyWebApp.Client.csproj` - Run web project
* `dotnet publish .\MyWebApp.Client\MyWebApp.Client.csproj -o ..\build -c Release` - Publish in release mode
* `dotnet add reference ../Gepie.Data/Gepie.Data.csproj` - Add reference to other project
* `dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.0.1` - Add nuget package
