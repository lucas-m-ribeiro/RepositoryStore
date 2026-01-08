using Microsoft.EntityFrameworkCore;
using RepositoryStore.Data;

var builder = WebApplication.CreateBuilder(args);

//Obtem a connection string do appsettings.json e armaneza na variavel
var connectionString =builder.Configuration.GetConnectionString("DefaultConnection");

//Configura o db context para usar o PostgreeSQL
builder.Services.AddDbContext<AppDbContext>(x =>
    x.UseNpgsql(connectionString));

var app = builder.Build();

app.MapGet("/", () => "Testando aplicação de repository pattern no dotnet C#");

app.Run();
