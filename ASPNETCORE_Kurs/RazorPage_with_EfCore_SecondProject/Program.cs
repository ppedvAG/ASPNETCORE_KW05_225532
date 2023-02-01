using Microsoft.EntityFrameworkCore;
using RazorPage_with_EfCore_SecondProject.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MovieDbContext>(options =>
{
    //options.UseInMemoryDatabase("MovieEvaluationDb"); //InMemoryDB ist bei jedem Programmstart leer!!!

    //via Lambda können wir für EF Core Optionen vornehmen 
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieDbConn")); //ConnectionString lesen wir aus der appsettings.json 
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
