//program execution in order:

//creating the builder
using AuctionService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
//dependency injection to make use of the Db service for classes to get access to the DbContext 
builder.Services.AddDbContext<AuctionDbContext>(opt => 
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//actually building
var app = builder.Build();

//middleware services TBD

//auth, direct http req to correct api, finally RUN
app.UseAuthorization();

app.MapControllers();

try
{
    DbInitializer.InitDb(app);
} 
catch(Exception e)
{
    Console.WriteLine(e);
};

app.Run();
