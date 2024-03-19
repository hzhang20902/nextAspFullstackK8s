//program execution in order:

//creating the builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//actually building
var app = builder.Build();

//middleware services TBD

//auth, direct http req to correct api, finally RUN
app.UseAuthorization();

app.MapControllers();

app.Run();
