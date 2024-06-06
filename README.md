# SolidPrinciplesDemo

This project demonstrates the implementation of SOLID principles using .NET 8 and PostgreSQL. The project structure is designed to be modular and maintainable, adhering to best practices in software development.

## Getting Started

### Prerequisites

- .NET 8 SDK
- PostgreSQL
- A code editor or IDE (e.g., Rider, Visual Studio, VS Code)

### Installation

1. **Clone the repository:**
   ```sh
   git clone https://github.com/YourUsername/SolidPrinciplesDemo.git
   cd SolidPrinciplesDemo
   ```
### Set up the database:

Ensure PostgreSQL is installed and running.
Update the connection string in SolidCodeBase.Api/appsettings.json with your PostgreSQL credentials.

### Restore dependencies:
```sh
dotnet restore
```

### Apply migrations and update the database:
```sh
dotnet ef migrations add InitialCreate --project SolidCodeBase.Data --startup-project SolidCodeBase.Api
dotnet ef database update --project SolidCodeBase.Data --startup-project SolidCodeBase.Api
```

## Running the Application
###Run the API project:
```sh
dotnet run --project SolidCodeBase.Api
```
The API will be available at http://localhost:5000.

## SOLID Principles
Single Responsibility Principle (SRP)
Description:
A class should have only one reason to change, meaning it should have only one job or responsibility.

Implementation:
In this project, each class has a single responsibility. For instance, Invoice is responsible for representing invoice data, while InvoiceService is responsible for processing invoices.

### Open/Closed Principle (OCP)
Description:
Software entities should be open for extension but closed for modification.

Implementation:
This is achieved by using interfaces and creating multiple implementations of services. For example, CreditCardPaymentService and PayPalPaymentService both implement the IPaymentService interface.

### Liskov Substitution Principle (LSP)
Description:
Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.

Implementation:
The UserRepository class extends the BaseRepository class and can replace it without affecting program correctness.

### Interface Segregation Principle (ISP)
Description:
No client should be forced to depend on methods it does not use. Instead of one large interface, many small interfaces are preferred.

Implementation:
We have created specific interfaces for different services, such as IInvoiceService and IPaymentService.

### Dependency Inversion Principle (DIP)
Description:
High-level modules should not depend on low-level modules. Both should depend on abstractions.

Implementation:
Dependency injection is used to provide implementations of interfaces, ensuring that high-level modules depend on abstractions rather than concrete classes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.


