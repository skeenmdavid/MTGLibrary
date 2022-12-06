using Microsoft.EntityFrameworkCore;
using MTGLibrary.Interfaces;
using MTGLibrary.Repos;
using MTGLibraryDA.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionstring = builder.Configuration.GetConnectionString("MTGLibraryDB");

builder.Services.AddDbContext<MTGLibraryContext>(options => options.UseSqlServer(connectionstring));

builder.Services.AddScoped<IExternalCardAPIAccess, ScryfallAPIAccess>();
builder.Services.AddScoped<IDatabaseAccess, MTGLibraryDataAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
