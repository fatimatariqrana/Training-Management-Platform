
# Training-Management-Platform

The Training-Management-Platform is a comprehensive web-based application designed for efficiently managing training and educational workflows for institutions. The application is modular, using .NET(C#) technologies, with clear separation of concerns across backend services, APIs, entities, and a web front-end.

**Project Structure**
TrainingManagementPlatform.Database: Database layer and migrations.

TrainingManagementPlatform.Entities: Data models/entities.

TrainingManagementPlatform.Services: Business logic and services.

TrainingManagementPlatform.Web: Web API for backend services.

TrainingManagementPlatform.Website: ASP.NET MVC front-end, with folders for Controllers, Models, Views, ViewModels, and scripts.


**Setup Instructions**
Clone this repository and open the .sln file in Visual Studio.

Configure the database connection (default: MySQL) in appsettings.json.

Restore NuGet packages and build the solution.

Run migrations to prepare the DB.

Start the API and Web projects as required.

Login and begin using the platform features.

**Technologies Used**
.NET Core / ASP.NET Core MVC

Entity Framework Core

MySQL

xUnit (testing)

MVC (front-end)

JWT for authentication
