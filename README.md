## �ħ|�B
�n�ϥ� `dotnet tool install --global dotnet-ef` �w�ˡA�~�i�H�ϥ�dotnet ef���O

## Entity Framework Core
---
- �إ�Model
- �إ�DbContext
- �]�w�s�u�r�� `optionsBuilder.UseSqlServer("Server=���A��;Database=��Ʈw�W��;Trusted_connection=true;TrustServerCertificate=true;");`
- ���Uservice
- program.cs > builder.Services.AddDbContext<XianguContext>();
- ��J���O `dotnet ef migrations add �H�K�����W��`
- ��J���O `dotnet ef database update`