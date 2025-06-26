using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Solvo_Web.Data;
using Solvo_Repository.Context;
using Microsoft.AspNetCore.Identity;
using Solvo_Repository.Context;
using Solvo_Web.Data;
using Solvo_Repository.Contracts;
using Solvo_Repository.UnitOfWork;
using Solvo_Repository;
using Solvo_Service.Contracts;
using Solvo_Service;
using Microsoft.Extensions.DependencyInjection;
using Solvo_Core.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

// Connection string
var connectionString = builder.Configuration.GetConnectionString("SqlConn");

// EF Core + Identity
builder.Services.AddDbContext<RepositoryContext>(options =>
    options.UseSqlServer(connectionString));



builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddSingleton<AppState>();
builder.Services.AddIgniteUIBlazor();




var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
