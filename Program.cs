using Microsoft.EntityFrameworkCore;
using UniversityofVirginia.Context;
using UniversityofVirginia.Controllers;
using UniversityofVirginia.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


//dbContext

builder.Services.AddDbContext<UniversityContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));




//Repositories

builder.Services.AddScoped<IStudentRepository, StudentRepository>();



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
