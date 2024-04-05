using data_access_layer.Domain.Context;
using data_access_layer.Domain.Entites.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registering the DbContext
var connectionString = builder.Configuration.GetConnectionString("EduSqlServer");
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("data_access_layer")));

// Registering the Identity
builder.Services.AddAuthorization();

// Activate identity API endpoints
builder.Services.AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<ApplicationDbContext>();


var app = builder.Build();

// Mapping identity endpoints
app.MapIdentityApi<User>();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
