http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application

https://msdn.microsoft.com/en-us/library/jj653752.aspx#attachdbfilename

https://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

http://www.asp.net/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application



Enable-Migrations -EnableAutomaticMigrations -Force
Enable-Migrations
Add-Migration Initial
Update-Database

Update-database -TargetMigration:0
Update-database

Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ExampleContext>());  

AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());

Update-Database -Verbose -Force -AppDomainBaseDirectory "C:\Path\To\bin"