var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

//app.MapGet("/{id}", (int id) => $"Hello World!{id}");
app.MapControllers();

app.Run();
