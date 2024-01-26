::dotnet tool install --global dotnet-ef 
dotnet ef dbcontext scaffold "Server=.;Database=SejatTest;Persist Security Info=True;MultipleActiveResultSets=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer --context EntekhabQueriesDbContext --output-dir Entities --no-onconfiguring --context-dir Entities/../  --force	--data-annotations  --table dbo.Resid  --table dbo.Mojavez 
powershell -Command "(gc EntekhabQueriesDbContext.cs) -replace '<Attribute>', '<Entities.Attribute>' | Out-File -encoding utf8 EntekhabQueriesDbContext.cs"
powershell -Command "(gc EntekhabQueriesDbContext.cs) -replace 'modelBuilder.HasDefaultSchema', '//' | Out-File -encoding utf8 EntekhabQueriesDbContext.cs"

pause