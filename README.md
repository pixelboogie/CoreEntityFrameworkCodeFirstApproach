# CoreEntityFrameworkCodeFirstApproach

## Description
This project is part of the Coursera course for the ".NET FullStack Developer Specialization" certification. It demonstrates the code-first approach to implementing an MVC application using Entity Framework Core.

The code-first approach involves creating domain classes and a DbContext class derived from the EF Core DbContext classes. These domain classes are used to generate database tables, where each entity must have a primary key column. The project includes the creation of a customer domain class and a DbContext class, along with configuring the database connection string.

Additionally, the project covers the process of migrating domain classes to the database using the `add migration` and `update database` commands. Finally, the project shows how to generate the database and tables and access them using object-relational mapping (ORM).

## Table of Contents
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Technologies Used
- **Entity Framework Core**: For ORM and database migrations.
- **ASP.NET Core MVC**: Framework for building the MVC application.
- **C#**: Programming language used in the project.
- **SQL Server**: Database management system for storing and retrieving data.

## Installation
To set up this project locally, follow these steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/CoreEntityFrameworkCodeFirstApproach.git
   cd CoreEntityFrameworkCodeFirstApproach

2. **Install Dependencies:**

    Ensure that you have the .NET SDK installed. Then, restore any required packages:

        dotnet restore


3. **Configure the Database Connection:**

    Update the appsettings.json file with your database connection string.


4. **Run Migrations:**

    Apply the migrations to create the database and tables:

        dotnet ef migrations add InitialCreate
        dotnet ef database update



5. **Run the Application:**

    Start the application using the following command:

        dotnet run

## Usage ##
Once the application is running, you can interact with the database through the MVC web interface. The application will allow you to manage entities such as customers, and perform CRUD (Create, Read, Update, Delete) operations using the code-first approach.


## License ## 
This project is licensed under the MIT License. See the LICENSE file for more information.
