var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Rud Andrii Evgeniyvich - group 'IPZ19-2'");

app.Run();
