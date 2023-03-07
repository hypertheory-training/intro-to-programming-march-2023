using Marten;
using Status;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(pol =>
    {
        pol.AllowAnyOrigin();
        pol.AllowAnyHeader();
        pol.AllowAnyMethod();
    });
});
//we configure "Servives" - Entitiesm values, services

var connectionString = "host=localhost;database=status_dev;username=postgres;password=TokyoJoe138!;port=5432";
builder.Services.AddMarten(options =>
{
    options.Connection(connectionString);
    options.AutoCreateSchemaObjects = Weasel.Core.AutoCreate.All;
});

var app = builder.Build();

app.MapGet("/status", async (IDocumentSession db) =>
{
    var response = await db.Query<StatusMessage>()
    .OrderByDescending(sm => sm.when)
    .FirstOrDefaultAsync(); if (response == null)
    {
        return Results.Ok(new StatusMessage(Guid.NewGuid(), "No Status to Report", DateTimeOffset.Now));
    }
    else
    {
        return Results.Ok(response);
    }
});

app.MapPost("/status", async (StatusChangerequest request, IDocumentSession db) =>
    {
        //save this in the database
        var messageToSave  = new StatusMessage(Guid.NewGuid(), request.Message, DateTimeOffset.Now);
        db.Store<StatusMessage>(messageToSave); //here's the list of work to do
        await db.SaveChangesAsync(); //do it

         return Results.Ok(messageToSave);
});



app.Run();  //Block