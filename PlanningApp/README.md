AU Travel Planning App

Technology stack
Programming language: C#
UI framework: Windows Forms
Database: SQLite, using Entity Framework Core for database management
ORM framework: Entity Framework Core
Unit testing: NUnit

Database migration
dotnet ef migrations add InitialCreate
dotnet ef database update

Clone repository
https://github.com/Adam2221114/TravelPlanningApp.git

External API Description
This project uses the weather API provided by Weatherbit to obtain weather information. 
Since Weatherbit provides a free API, there are restrictions on its use, and it can only obtain unified weather data for a single region. 
The free use of the API is valid until November 14th.
https://www.weatherbit.io/

Database Visualization Description
This project uses the SQLite Loction database. If you need to visualize the data, you can choose two methods:
1. Download DB Browser for SQLite
2. Use SQLite and SQL Servercompact Toolbox (easiest)
Open the Visual Studio extension and download it to use, connect to the local Bin->Debug-> net8.0-windows-> localdatabase.db
