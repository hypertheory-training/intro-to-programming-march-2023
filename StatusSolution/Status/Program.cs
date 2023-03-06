// See https://aka.ms/new-console-template for more information
using Status;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/status", () =>
{
    var statusMessage = new StatusMessage(Guid.NewGuid(), "Looks Good", DateTimeOffset.Now);
    return Results.Ok(statusMessage);
});



app.Run();