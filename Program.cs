var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Testando aplicação de repository pattern no dotnet C#");

app.Run();
