using ArchitectureSkeleton.Expansion;
using ArchitectureSkeleton.SqlBulid.Concrete;
using ArchitectureSkeleton.SqlBulid.Contract;
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

builder.Services.AddScoped(typeof(ISqlQuery<>), typeof(SqlQuery<>));
builder.Services.AddScoped(typeof(ISqlInsert<>), typeof(SqlInsert<>));
builder.Services.AddScoped(typeof(ISqlUpdate<>), typeof(SqlUpdate<>));
builder.Services.AddScoped(typeof(ISqlDelete<>), typeof(SqlDelete<>));
builder.Services.AddScoped<ISqlBulider, SqlBulider>();

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
