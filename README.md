# Flyingcape Test Project

API for E-Learning App

# Installation

Make sure you have .Net and Microsoft SQL Server installed.

Clone the project 

```bash
git clone https://github.com/fahmiram18/api-flyingcape-test.git
cd api-flyingcape-test
```

Create database

```sql
CREATE DATABASE `db_flyingcape_test`;
USE db_flyingcape_test;
```

Run Migration and Update Database

```bash
dotnet ef add-migration InitialCreate
dotnet ef Update-Database
```

Start the server
```bash
dotnet run
```

# Request Collection

You can see Request Collection when run the app.
