# Simple Console Application with DTOs and AutoMapper

### Overview

This is a simple console application written in .NET that demonstrates the usage of Data Transfer Objects (DTOs) and the AutoMapper library. The application focuses on a basic scenario to facilitate personal learning.

### Purpose

The purpose of this application is to illustrate how to:

1. Define Data Transfer Objects (DTOs) - BookInputModel and BookViewModel.
2. Use the AutoMapper library to map between DTOs and domain models.
3. Create a basic console application to showcase the functionality.

### Project Structure

1. *Program.cs:* The main entry point of the console application. It creates an instance of the Books class and uses AutoMapper to map it to BookInputModel and BookViewModel.
2. *DTOs/AutoMapper/MapperConfig.cs:* Contains the configuration for AutoMapper, setting up the mappings between DTOs and the domain model (Books).
3. *DTOs/InputModels/BookInputModel.cs:* Represents the input model with properties for book details.
4. *DTOs/ViewModels/BookViewModel.cs:* Represents the view model with properties for book details, including the creation date.
5. *Models/Books.cs:* Defines the domain model representing a book.

### Note

_This application is intentionally kept simple and serves as a learning exercise for understanding the implementation of DTOs and AutoMapper in a .NET console application. It does not aim to solve a real-world problem but rather provides a hands-on example for educational purposes._