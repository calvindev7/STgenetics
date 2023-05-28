# Animal Purchasing Management System


## Description
This project is an animal purchasing management system that allows customers to explore and acquire animals of different breeds. It provides an intuitive and user-friendly interface for placing orders and generating billing details.

## Key Features
- Search and selection of animals by breed, gender, and status.
- Adding animals to the shopping cart.
- Automatic application of discounts based on business rules.
- Calculation of shipping cost based on the number of animals.
- Generation of billing details with comprehensive order information.
- Thank you modal upon completing the purchase.

## Technologies Used
- ASP.NET Core
- HTML, CSS, and JavaScript
- Bootstrap
- DataTables
- Entity Framework Core

## Project Setup and Execution
1. Clone the project repository from GitHub.
2. Open the project in your preferred development environment (e.g., Visual Studio).
3. Make sure you have the necessary dependencies and tools installed, such as the .NET Core SDK.
4. Configure the database connection in the `appsettings.json` file according to your needs. Here's an example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=DatabaseName;User=User;Password=Password;"
  }
}
```
5. Run the migrations to create the necessary database and tables. Use the following command:

```shell
dotnet ef database update
```

6. Build and run the application. Use the following command:

```shell
dotnet run
```

## Contribution
If you would like to contribute to this project, follow these steps:
1. Fork the repository.
2. Create a branch with a descriptive name for your feature or bug fix.
3. Make the changes in your branch and ensure the code is consistent with the project's conventions.
4. Submit a pull request explaining the changes made and their purpose.

We appreciate any contributions that help improve this animal purchasing management system.

## Support
If you have any questions, issues, or suggestions related to this project, feel free to open a new issue on the GitHub repository. We'll be happy to assist you.

Thank you for your interest and support in this animal purchasing management project!
