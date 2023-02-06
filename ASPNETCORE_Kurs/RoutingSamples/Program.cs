var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options=>
{
    //Optionale Einstellung für RazorPages vornehmen

    //Beispiel1:
    options.Conventions.AddPageRoute("/sample/friendlyRouteSample/friendlyRouteSample", "Blog/{year}/{month}/{day}/{title}");



    //Beispiel2:
    //options.Conventions.AddPageRoute("/sample/friendlyRouteSample/friendlyRouteSample", "Blog");
});
builder.Services.AddControllersWithViews();

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
