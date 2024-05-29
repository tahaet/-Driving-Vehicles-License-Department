# Driving and Vehicles License Department Application

This WinForms application is designed for managing driving and vehicle licenses within a department. It is developed using C# .NET Framework 4.8 and utilizes SQL Server for data storage. ADO.NET is employed for database connectivity.

## Features

- **User Authentication**: Secure login system to access the application.
- **Error Handling and Validation**: Robust error handling and input validation mechanisms are implemented to ensure data integrity and prevent potential security vulnerabilities.
- **Manage Drivers**: Create, update, and delete driver information.
- **Manage Vehicles**: Track vehicle details including registration, ownership, and inspection data.
- **Local and International License Management**: Manage both local and international driving licenses, including tests and requirements for each.
- **License Issuance**: Issue and renew driving licenses.
- **License Verification**: Ability to verify license validity.
- **Search Functionality**: Search for drivers or vehicles based on various criteria such as name, license plate, etc.
- **Fine Management**: Record and manage fines issued to drivers for violations.
- **User Roles and Permissions**: Assign different roles (admin, clerk, inspector) with varying levels of access to features.

## Requirements

- Microsoft Visual Studio with C# .NET Framework 4.8 installed.
- SQL Server Management Studio for database setup and management.
- Access to a SQL Server instance (local or remote).

## Database Schema

The application uses the following tables in the SQL Server database:

- **Applications**: Manages various license applications.
- **ApplicationTypes**: Defines types of license applications.
- **Countries**: Stores information about countries.
- **DetainedLicenses**: Tracks detained licenses and reasons for detention.
- **Drivers**: Stores information about registered drivers.
- **InternationalDrivingLicenses**: Manages international driving licenses.
- **LicenseClasses**: Defines classes/types of driving licenses.
- **Licenses**: Tracks issued driving licenses.
- **LocalDrivingLicenseApplications**: Manages applications for local driving licenses.
- **People**: Contains personal information about individuals.
- **TestAppointments**: Schedules appointments for driving tests.
- **Tests**: Stores information about driving tests.
- **TestTypes**: Defines types of driving tests.
- **Users**: Stores user credentials for authentication.

## Usage

- Upon launching the application, users will be prompted to log in with their credentials.
- Once logged in, users can navigate through different functionalities using the sidebar menu.
- They can add, edit, or delete driver and vehicle information as necessary.
- License issuance and verification can also be performed from the respective sections.
  
