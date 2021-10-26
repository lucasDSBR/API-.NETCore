# API-.NETCore

- **Estrutura:**
    - Api.Application
    - Api.Domain
    - Api.CrossCutting
    - Api.Data
    - Api.Service


## Pacotes instalados:
    - Microsoft.EntityFrameworkCore.SqlServer
        -  dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.6
    - Pomelo.EntityFrameworkCore.MySql
        -  dotnet add package Pomelo.EntityFrameworkCore.MySql --version 3.1.1
    - Microsoft.EntityFrameworkCore.Tools 
        -  dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.1.6
    - Microsoft.EntityFrameworkCore.Design 
        -  dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.6


## Criando banco de dados
    - dotnet: dotnet ef migrations add <Nome da migração>
    - dotnet: dotnet ef database update