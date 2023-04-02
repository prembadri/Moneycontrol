using Microsoft.OpenApi.Models;
using Moneycontrol.BAL.Contracts;
using Moneycontrol.BAL.Services;
using Moneycontrol.DAL.Contracts;
using Moneycontrol.DAL.DataSource;
using Moneycontrol.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo()
    {
        Title = "Money Control - Budget App",
        Contact = new OpenApiContact()
        {
            Email = "badripremkumar1@gmail.com",
            Name = " Prem kumar Badri",
        },
        Description = "Small Budget Tracking API"
    });
});

builder.Services.AddTransient<ISQLiteOperator>(sqlite =>
{
    return new SQLiteOperator("Data Source=Budget.db");
});
builder.Services.AddTransient<ICategoryTypesRepository, CategoryTypesRepository>();
builder.Services.AddTransient<ICategoryTypesService, CategoryTypesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
