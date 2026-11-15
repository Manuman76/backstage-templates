var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new { Message = "Hello from .NET Core ${{ values.componentType }}: ${{ values.name }}!", Type = "${{ values.componentType }}" });
app.MapGet("/health", () => Results.Ok(new { Status = "healthy" }));

app.Run("http://0.0.0.0:8080");
