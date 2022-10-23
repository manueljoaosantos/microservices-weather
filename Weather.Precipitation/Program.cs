using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
//http://localhost:4000/observation/zip
app.MapGet("/observation/{zip}", (string zip, [FromQuery] int? days) => {
    return Results.Ok(zip);
});

app.Run();
