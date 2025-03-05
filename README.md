# ChozaGamer

This is a small WinForms project that i created as a part of a school assignment. During its development, I applied my knowledge of WinForms, SQL Server, Entity Framework and Repository Pattern.

![Login image](https://raw.githubusercontent.com/blasestevez/ChozaGamer/refs/heads/master/CnP_05032025_161013.png?token=GHSAT0AAAAAAC7SBZX5LKSMUXAQKBTFUQRQZ6IWEGQ)

![Client panel Image](https://raw.githubusercontent.com/blasestevez/ChozaGamer/refs/heads/master/CnP_05032025_161023.png?token=GHSAT0AAAAAAC7SBZX5KYFCWBJ7RV6PO3RGZ6IWFAQ)

---

## Features

This project offers the following features:

- **User Management**:
  - Secure registration using ASP.NET Identity.
  - Login and credential validation.
  - User classification as "admin" or "client".
- **Product Management**:
  - Create, edit, and view products as a admin.
  - View products as a client and buy them.
  - Data validation to ensure consistency and quality.
- **Scalable Architecture**:
  - Implements patterns like Repository and DTOs.
  - Configured AutoMapper to simplify handling of models and DTOs.

---

## Technologies Used

This project was built using the following technologies:

- **ASP.NET Core 8**: For building the web application.
- **Entity Framework Core**: To manage database interactions using an ORM.
- **SQL Server**: For storing data persistently.
- **ASP.NET Identity**: To handle user authentication and authorization.
- **AutoMapper**: To map domain models to DTOs and vice versa.
- **C#**: As the primary programming language for the backend.
- **Git**: For version control and collaboration.

---

## Getting started

To get started with this project, clone the repository and set up your development environment. Follow the steps below to run the application locally.

### Prerequisites

Make sure you have the following installed on your machine:

- **.NET 8 SDK** or higher
- **SQL Server** for the database
- **Git** to clone the repository

### Installation

1. Clone the repository:
   ```shell
   git clone https://github.com/blasestevez/ChozaGamer.git
   cd ChozaGamer
   ```

2. Configure the database:
   - Open the `Program.cs` and `DesignTimeDbContextFactory.cs` file and adjust the connection string:
     ```csharp
     options.UseSqlServer("Server=<Your server>;Database=ChozaGamer;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True"));
     ```
     ```csharp
     optionsBuilder.UseSqlServer("Server=<Your server>;Database=ChozaGamer;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True"));
     ```

3. Apply database migrations:
   ```shell
   Update-Database -Project "ChozaGamer.DataAccess" -StartupProject "ChozaGamer.Presentation"
   ```

4. Run the project:
   ```shell
   dotnet run --project ChozaGamer.Presentation
   ```
