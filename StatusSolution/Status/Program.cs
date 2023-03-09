//// See https://aka.ms/new-console-template for more information
//using Status;

////Console.WriteLine("Hello, World!");
////Console.WriteLine("This is another line");

////var statusId = Guid.NewGuid().ToString();
////var statusMessage = "Looks good. Just learning some .net";
////var statusTime = DateTimeOffset.Now;
////Console.WriteLine($"The id {statusId} status: {statusMessage} at {statusTime}");

////Console.WriteLine("This is a .NET Application!");
////Console.WriteLine("Another line!"); 
//////var statusId = Guid.NewGuid().ToString();
//////var statusMessage = "Looks good. Just learning some .net";
//////var statusTime = DateTimeOffset.Now;
/////





////var statusMessage = new StatusMessage(Guid.NewGuid(), "Looks Good", DateTimeOffset.Now);

////Console.WriteLine($"The id {statusMessage.Id} status: {statusMessage.Message} at {statusMessage.When}");




//var builder = WebApplication.CreateBuilder(args);

//var app = builder.Build();

//app.MapGet("/status", () =>
//{
//    var statusMessage = new StatusMessage(Guid.NewGuid(), "Looks Good", DateTimeOffset.Now);
//    return Results.Ok(statusMessage);
//});


//app.Run();


/////  
///

using Marten;
using Status;


internal class Program
{
    private static void Main(string[] args)
    {
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

        // we configure "services" - Entities, Values, Services
        var connectionString = "host=localhost;database=status_dev;username=postgres;password=TokyoJoe138!;port=5432";
        builder.Services.AddMarten(options =>
        {
            options.Connection(connectionString);
            if (builder.Environment.IsDevelopment())
            {
                options.AutoCreateSchemaObjects = Weasel.Core.AutoCreate.All;
            }

        });

        var app = builder.Build();

        app.UseCors();

        app.MapGet("/status", async (IDocumentSession db) =>
        {
            var response = await db.Query<StatusMessage>()
            .OrderByDescending(sm => sm.When)
            .FirstOrDefaultAsync();

            if (response == null)
            {
                return Results.Ok(new StatusMessage(Guid.NewGuid(), "No Status to Report", DateTimeOffset.Now));
            }
            else
            {

                return Results.Ok(response);
            }
        });

        app.MapPost("/status", async (StatusChangeRequest request, IDocumentSession db) =>
        {
            // save this in the database 
            var messageToSave = new StatusMessage(Guid.NewGuid(), request.Message, DateTimeOffset.Now);
            db.Store(messageToSave); // here's the list of work to do.
            await db.SaveChangesAsync(); // do it!
            return Results.Ok(messageToSave);
        });

        app.Run(); // "Block" 
    }
}



//var statusMessage = new StatusMessage(Guid.NewGuid(), "Looks Good", DateTimeOffset.Now);

//Console.WriteLine($"The id {statusMessage.Id} status: {statusMessage.Message} at {statusMessage.When}");