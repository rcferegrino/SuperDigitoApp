# SuperDigitoApp
SuperDigitoApp is a web application built using ASP.NET Core and Blazor, designed to provide an interactive web experience with authentication, authorization, and a modular, component-based architecture.
This application specifically includes features like user authentication through ASP.NET Identity, database integration with Entity Framework Core, and the use of Razor Components for building the front-end interface. The repository also includes services, components, and a modular structure for extensibility.
## Key Features
### Backend
- **ASP.NET Core Framework**: Leveraging the latest .NET 8.0 capabilities for high-performance web development.
- **Entity Framework Core**: Database interaction through EF Core, currently configured to use SQLite.
- **Authentication & Authorization**:
    - Integrated with `ASP.NET Identity` for user authentication and management.
    - Custom Authentication State with `IdentityRevalidatingAuthenticationStateProvider`.
    - Authorization policies like `"AuthorizedUsersOnly"` to restrict access.

- **Automatic Database Migration**: Automatically applies Entity Framework migrations at runtime.

## Database
The application uses **SQLite** as the database provider. It leverages Entity Framework Core for managing database schema and data interactions. The automatic migration feature ensures schema changes are applied on startup using `context.Database.Migrate()`.
Below is an example of the **Entity Relationship Diagram (ERD)** for the main database tables:
``` plaintext
+----------------------+
|     ApplicationUser  |
+----------------------+
| Id (PK)             |
| UserName            |
| Email               |
| PasswordHash        |
| ...                 |
+----------------------+
          |
          +----------------------+
          |                      |
+---------v-------------+  +-----v----------+
| IdentityUserLogin     |  | IdentityUserRole|
+-----------------------+  +-----------------+
| UserId (FK, PK)       |  | UserId (FK, PK)|
| LoginProvider (PK)    |  | RoleId (FK, PK)|
| ProviderKey (PK)      |  +----------------+
+-----------------------+

+----------------------+
|     ApplicationRole  |
+----------------------+
| Id (PK)             |
| Name                |
| ...                 |
+----------------------+
```
### Explanation of the Tables:
1. **ApplicationUser**: Represents the users of the application, extending Identity's `IdentityUser` with additional custom properties.
2. **ApplicationRole**: Stores user roles for authorization.
3. **IdentityUserLogin**: Manages external logins for users (e.g., Google, Facebook).
4. **IdentityUserRole**: Links users to roles they belong to.

This diagram captures the structure of a typical ASP.NET Identity setup, designed for flexible user management and role-based authorization. Additional domain-specific tables (e.g., for application-specific features) may also exist in the database.

### Frontend
- **Blazor Interactive Components**:
    - Built using Razor Components for modern, single-page interactive user experiences.
    - Razor Components server mode with real-time rendering.

- **State Management**:
    - Cascading Authentication State for user-specific UI.
    - Modular component-based frontend using Blazor.

### Services
- **Super Digit Feature**: Includes services like `ISuperDigitCalculator` with its implementation `SuperDigitCalculator` to handle relevant business logic.
- **Email Sending**: Stubbed interface for sending emails (`IEmailSender<ApplicationUser>`), with a no-op default implementation provided (`IdentityNoOpEmailSender`).

## Technologies Used

| **Technology** | **Version** |
| --- | --- |
| ASP.NET Core | `.NET 8.0` |
| Blazor | `Razor Components` |
| Entity Framework Core | `SQLite` |
| ASP.NET Identity | Latest |
| C# | `12.0` |
## Getting Started
### Prerequisites
To run the application locally, ensure you have the following installed:
- [.NET SDK 8.0]() or later
- SQLite CLI (optional, for database management)

### Setting Up the Environment
1. **Clone the Repository**: