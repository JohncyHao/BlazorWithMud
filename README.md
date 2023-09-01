## 採坑處
要使用 `dotnet tool install --global dotnet-ef` 安裝，才可以使用dotnet ef指令

## Entity Framework Core
---
- 建立Model
- 建立DbContext
- 設定連線字串 `optionsBuilder.UseSqlServer("Server=伺服器;Database=資料庫名稱;Trusted_connection=true;TrustServerCertificate=true;");`
- 註冊service
- program.cs > builder.Services.AddDbContext<XianguContext>();
- 輸入指令 `dotnet ef migrations add 隨便取的名稱`
- 輸入指令 `dotnet ef database update`