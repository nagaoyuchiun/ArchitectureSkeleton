using ArchitectureSkeleton.Contract.Repository;
using ArchitectureSkeleton.Expansion;
using System.Data;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IDbConnection>(serviceProvider =>
{
    var connectionString = serviceProvider.GetRequiredService<IConfiguration>().GetConnectionString("DefaultConnection");
    return new SqlConnection(connectionString);
});

builder.Services.AddControllers();

builder.Services.AddScoped(typeof(ICommandRepository<>), typeof(ArchitectureSkeleton.Data.Dapper.Repository<>));

builder.Services.AddHandler();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
