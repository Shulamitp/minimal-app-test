var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.WebHost.UseUrls("http://+:80");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

var dbConnection = Environment.GetEnvironmentVariable("DB_CONNECTION");
app.MapGet("/", () => Results.Text(Logic.GetMessage(dbConnection)));


app.Run();


public static class Logic
{
    public static string GetMessage(string? dbConnection)
    {
        if (string.IsNullOrEmpty(dbConnection))
            return "almost there, secret: DB_CONNECTION is not set";

        return $"hello word - {dbConnection}";
    }
}
