# ecommerceapp

Ecommerce App - C# .NET and Angular
This application is built using C# .NET on the backend and Angular on the frontend. It provides a complete solution for managing an online store, including product listing, shopping cart functionality, user management, and order processing. The application uses PostgreSQL as the database to store product information, user data, and order details.


The Ecommerce App provides the following features:

Product Management: Create, update, and delete products, including their images, descriptions, and pricing.

Shopping Cart: Add products to a cart, update quantities, and proceed to checkout for order placement.

User Authentication: Register new users and allow existing users to log in securely.

Order Processing: Generate and process orders, including order confirmation, payment, and shipping details.

Technologies

The application utilizes the following technologies:

C# .NET: A powerful and versatile programming language and framework for building robust web applications.

Angular: A widely adopted JavaScript framework for building dynamic and responsive user interfaces.

PostgreSQL: An open-source, highly scalable, and reliable relational database management system.

HTML/CSS: Standard web technologies for structuring and styling the user interface.

JavaScript/TypeScript: Programming languages used for client-side logic and interactivity.

Payment Gateway Integration: Integration with popular payment gateway Stripe.

Installation
To set up the eCommerce application locally, follow these steps:

Clone the repository

Install the necessary dependencies for the .NET backend. Open a terminal, navigate to the backend directory, and run dotnet restore

Install the required packages for the Angular frontend. Open a terminal, navigate to the frontend directory, and run npm install



Usage

To start the eCommerce application, follow these steps:

Start the .NET backend server. Open a terminal, navigate to the backend directory, and run:
dotnet run

Start the Angular frontend. Open a new terminal, navigate to the frontend directory, and run:
ng serve


Access the application by opening a web browser and visiting http://localhost:4200.



Database Setup

To set up the PostgreSQL database for the application, follow these steps:
Create a new PostgreSQL database.
Run the database migration scripts provided in the backend/Migrations directory to create the necessary tables and schema.
dotnet ef database update


The database is now ready for use with the eCommerce application.



