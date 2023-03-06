// See https://aka.ms/new-console-template for more information
using Status;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("This is another line");

//var statusId = Guid.NewGuid().ToString();
//var statusMessage = "Looks good. Just learning some .net";
//var statusTime = DateTimeOffset.Now;
//Console.WriteLine($"The id {statusId} status: {statusMessage} at {statusTime}");

//Console.WriteLine("This is a .NET Application!");
//Console.WriteLine("Another line!"); 
////var statusId = Guid.NewGuid().ToString();
////var statusMessage = "Looks good. Just learning some .net";
////var statusTime = DateTimeOffset.Now;
///





//var statusMessage = new StatusMessage(Guid.NewGuid(), "Looks Good", DateTimeOffset.Now);

//Console.WriteLine($"The id {statusMessage.Id} status: {statusMessage.Message} at {statusMessage.When}");




var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/status", () =>
{
    var statusMessage = new StatusMessage(Guid.NewGuid(), "Looks Good", DateTimeOffset.Now);
    return Results.Ok(statusMessage);
});


app.Run();

