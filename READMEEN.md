# 👟 RetroShoes E-commerce 

<p align="center">
  | <span>English</span> | 
    <a href=README.md>Español</a> |
</p>
<br>


## 📃 Description:
This project is an e-commerce for shoes developed with ASP.NET Core, which utilizes a SQL database to store information about products, users, and other relevant entities. Additionally, an API has been implemented using Swagger to perform CRUD (Create, Read, Update, Delete) operations on the product database, as well as filters by gender and brand.

## 🚀 Main Features

- **ASP.NET Core**: The project is developed using ASP.NET Core, providing a robust and scalable platform for web application development.
- **SQL Database**: A SQL database is used to store information about products, users, and other system entities.
- **Swagger API**: An API has been implemented with Swagger, facilitating documentation and consumption of web services.
- **Secure CRUD Operations**: The API allows performing CRUD operations on the database securely, implementing measures to prevent and mitigate possible SQL injection attacks.
- **Filters by Gender and Brand**: Users can filter shoes by gender and brand for a personalized shopping experience.
- **Login and Registration**: Login and registration functionality is provided for users.

## 📝 To-Do List 
  - [ ] 🛒 Shopping Cart: Implement shopping cart functionality to allow users to add products, modify quantities, and remove products from the cart before proceeding to checkout.

 - [ ] 🛍️ Order Completion: Develop the flow for users to complete the purchase order once they have reviewed and confirmed the products in their cart. This includes order generation, total calculation, and integration with payment gateways.

 - [ ] 🔒 Additional Security: Strengthen system security by implementing measures such as two-factor authentication, secure session management, and stricter password policies.

 - [ ] 🧪 Unit and Integration Testing: Write unit and integration tests to ensure the reliability and proper functioning of the system in different scenarios and use cases.

 - [ ] ⚡ Performance Optimization: Perform optimizations in code and the database to improve application performance, reducing load times and increasing responsiveness.


## 🛠️ System Requirements

- **ASP.NET Core SDK**: The ASP.NET Core SDK must be installed to compile and run the project.
- **SQL Server**: An instance of SQL Server is required to host the system database.
- **Web Browser**: To interact with the application through the user interface.

## ⚙️ Project Setup

1. **Clone the Repository**: Clone the project repository from GitHub.

```bash
git clone https://github.com/SantiagoAnzola1/RetroShoes.git
```

2. **Create `appsettings.Development.json` File**: Create the **`appsettings.Development.json`** file inside the UserAPI folder and include:
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },

  "ConnectionStrings": {
    "DefaultConnection": "data source=<Server name>;initial catalog=<database name>;User Id=<user id/ username>;Password=<password>"
  },
  "AllowedHosts": "*"
}
```
3. **Configure the Database**: Configure a SQL Server database and update the connection string in the `appsettings.Development.json` file with your SQL Server instance information.

```json
"ConnectionStrings": {
    "DefaultConnection": "data source=<Server name>;initial catalog=<database name>;User Id=<user id/ username>;Password=<password>"
  }
```
4. **Create Database**: Download the `SQLQuery1.sql` file and execute it in your preferred relational database management system.

5. **Compile and Run the Project**: Open the project in your preferred development environment (Visual Studio, Visual Studio Code, etc.) and compile the project. Then, run it to start the web server.

6. **Access API Documentation**: Once the project is running, access the Swagger API documentation at `http://localhost:<port>/swagger`.
