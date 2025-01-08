using BookHub.BussinessLayer.Abstract;
using BookHub.BussinessLayer.Concrete;
using BookHub.DataAccesLayer.Concrete;
using BookHub.EntityLayer.Concrete;
using BookHub.WebApi;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddScoped<IHikayeService, HikayeManager>(); //yeni


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();



builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});



// Startup sýnýfýný kullan
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);
var app = builder.Build();//HATA ALDIM BURDA

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapDefaultControllerRoute();//yeni
app.UseAuthentication();
app.UseAuthorization();//
app.UseCors("AllowAll");
app.MapControllers();
app.UseRouting();//yeni
// Middleware'leri ekle
startup.Configure(app, app.Environment);
app.Run();
