# asp.net core dengan postgresql

1. Instalasi package database postgres
`dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 2.1.0`

2. Instalasi package entity framework
`dotnet add package NpgSql.EntityFrameworkCore.PostgreSQL.Design`

3. Migration database
 `dotnet ef migrations add initial`

4. Update migration database
`dotnet ef database update`