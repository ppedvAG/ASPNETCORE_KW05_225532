using Microsoft.EntityFrameworkCore;
using RazorPage_with_EFCore_Intro.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//EF Core wird verwendet
//Achtung EF Core Dienst wird als Scope intern verwendet
builder.Services.AddDbContext<MovieDbContext>(options =>
{
    //options.UseInMemoryDatabase("MovieEvaluationDb"); //InMemoryDB ist bei jedem Programmstart leer!!!

    //via Lambda können wir für EF Core Optionen vornehmen 
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieDbConn")); //ConnectionString lesen wir aus der appsettings.json 
});


var app = builder.Build();


using (IServiceScope scope = app.Services.CreateScope())
{
    MovieDbContext? movieDbContext = scope.ServiceProvider.GetService<MovieDbContext>();

    DataSeeder.SeedMoviesInDb(movieDbContext);
}


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
