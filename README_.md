<br>
<p align="center">
  <u><big>|| <b>TournamentTracker</b> ||</big></u>
  <br>
  <em>Epicodus - Capstone - Code Review</em>
  <br>
  ___________________________
  <br>
  <strong>Jessi B</strong>
  <br>
  <small>May 2022</small>
</p>

------------------------------

### <u>Table of Contents</u>
* <a href="#-description">Description</a>
* <a href="#-technologies-used">Technologies Used</a>
* <a href="#-setup-&-installation">Setup & Installation</a>
* <a href="#-known-bugs">Known Bugs</a>
* <a href="#-contact">Contact</a>
* <a href="#-license">License</a>

------------------------------

### Description
An API that functions as a US Parks archive for national, state and city parks. It utilizes RESTful principles and version control. The user is able to see the in-use version of the API when using Postman.
#
### Technologies Used
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL 8.0.20 for Linux](https://dev.mysql.com/)
* [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
* [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
* HTML
* CSS
#
### Description
This is a web app for generating single elimintaion tournament bracket. User can create, read, update & delete tournaments and competitors and generate a bracket from the tournaments competitor list. App uses ACID SQL database to hold tournament stats.
#
### Setup & Installation
* Download Microsoft .NET Core: [Mac users click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) OR [Windows users click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer)
* Install dotnet script: Enter the command ``dotnet tool install -g dotnet-script`` in terminal
* Install MySQL Workbench: [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/)
* Install Postman: (Optional) [Download and install Postman](https://www.postman.com/downloads/)
* Clone Repo: In your terminal, navigate to your desktop or other desired location and enter `git clone https://github.com/jessb-epicodus/USParkAPI.Solution.git`
* Add Required Packages: Navigate to the top level of the project directory called _USParkAPI_ & enter each of the following commands:
```
  dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0
  dotnet add package Microsoft.AspNetCore.Mvc.Versioning --version 5.0.0
```
* Protect Your MySQL Password: Enter `touch .gitignore` & `touch appsettings.json` in the command line
* Add the following code to _appsettings.json_ & update the server, port, and user id & password as necessary:
  ```
  {
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft": "Warning",
        "Microsoft.Hosting.Lifetime": "Information"
      }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=US_park;uid=root;pwd=YOUR PASSWORD;"
    }
  }
  ```
* Add _*/appsettings.json_ to _.gitignore_
* Update Database: Enter `dotnet ef migrations add <MigrationName>` & `dotnet ef database update` in the terminal
* Install Dependecies: Enter `dotnet restore` in your terminal
* Try Out This Web App: Enter `dotnet run` in the command line and either,
  * Navigte to _http://localhost:5000/_ in Postman - or -
  * Navigate to _http://localhost:5000/swagger_ in your browser
* _This is not yet published_
#
### Known Bugs
No known issues
#
### License
Copyright (c)  _Mar 2022_  _Jessi B_
#
### Contact
_If you run into any issues or have questions, ideas or concerns or wish to make a contribution to the code see contact information below._
* Jessi B <jessb.epicodus@gmail.com>
------------------------------

<center><a href="#">Return to Top</a></center>