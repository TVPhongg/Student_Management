using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Student_Management.Data.Context;
using Student_Management.Data.Entities;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);


//connection string for connect to database
builder.Services.AddDbContext<ManagementContext>(
       options => options.UseSqlServer("name=ConnectionStrings:ManagementConn"));

// Add services to the container.
builder.Services.AddScoped<ManagementContext>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<ManagementContext>()
                .AddDefaultTokenProviders();

builder.Services.AddControllers();
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
