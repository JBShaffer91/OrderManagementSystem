# Order Management System

A simple order management system built using ASP.NET Core MVC. This application allows users to manage vendors and their corresponding orders. The project follows the MVC architecture and demonstrates the use of RESTful conventions for routing.

## Features

- Splash page as the landing page.
- Manage vendors with Create, Read, Update, and Delete (CRUD) operations.
- Manage orders with Create, Read, Update, and Delete (CRUD) operations.
- Thoroughly tested models using Xunit.
- Polished, portfolio-quality UI and codebase.

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) version 5.0 or later.
- [Visual Studio Code](https://code.visualstudio.com/) or another compatible IDE.
- Git terminal (optional).

### Installation

1. Clone the repository:

https://github.com/JBShaffer91/OrderManagementSystem.git


2. Open the project in Visual Studio Code or your preferred IDE.

3. Restore the NuGet packages:

dotnet restore


4. Run the application:

dotnet run


5. Open a web browser and navigate to `https://localhost:5001` to start using the application.

## Running the Tests

To run the tests for the `Vendor` and `Order` models, use the following command:

dotnet test


## Built With

- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/) - The web framework used.
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - Object-database mapper for .NET.
- [Xunit](https://xunit.net/) - Testing framework for .NET.

## Authors

- Your Name - *Initial work* - Justin Shaffer (https://github.com/JBShaffer91)

## License

Copyright 2023 Justin Shaffer

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

## Acknowledgments

- OpenAI's ChatGPT for project guidance and code examples.
