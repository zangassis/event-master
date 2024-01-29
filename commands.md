```bash
dotnet new webapi -n EventMaster

dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.AspNetCore.OpenApi

dotnet ef migrations add InitialCreate
dotnet ef database update
```

