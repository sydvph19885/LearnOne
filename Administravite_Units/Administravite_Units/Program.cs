using Data;
using Data.Reponsitory;
using Data.Reponsitory.impl;
using Microsoft.EntityFrameworkCore;
using Service.Helper;
using Service.Service;
using Service.Service.impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var configuration = new ConfigurationBuilder()
//    .SetBasePath(System.IO.Directory.GetCurrentDirectory())
//    .AddJsonFile("appsettings.json")
//    .Build();
//var connectionString = configuration.GetConnectionString("MyDB");
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(options =>
{
    //options.UseNpgsql(connectionString);
    options.UseNpgsql(builder.Configuration.GetConnectionString("MyDB"));
});
// dang ki mapper
builder.Services.AddAutoMapper(typeof(Program));
//

builder.Services.AddScoped<IProvincesReponsitory, ProvincesReponsitory>();
builder.Services.AddScoped<IProvincesService, ProvincesService>();
builder.Services.AddScoped<IDistrictsReponsitory, DistrictsReponsitory>();
builder.Services.AddScoped<IDistrictsService, DistrictsService>();
builder.Services.AddScoped<IWardsReponsitory, WardsReponsitory>();
builder.Services.AddScoped<IWardsService, WardsService>();


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
