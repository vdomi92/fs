using fullstack_quiz_app_elte.Server.BLL.Contracts;
using fullstack_quiz_app_elte.Server.BLL.Services;
using fullstack_quiz_app_elte.Server.DAL.Contracts;
using fullstack_quiz_app_elte.Server.DAL.Domain.Context;
using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;
using fullstack_quiz_app_elte.Server.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("QuizSqlServer")));
// Registering the Identity
builder.Services.AddAuthorization();

// Activate identity API endpoints
builder.Services.AddIdentityApiEndpoints<AppUser>(options => {
    options.Password.RequiredLength = 6;
    options.Password.RequireDigit = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;

    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    options.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IQuizService, QuizService>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

// Mapping identity endpoints
app.MapIdentityApi<AppUser>();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
