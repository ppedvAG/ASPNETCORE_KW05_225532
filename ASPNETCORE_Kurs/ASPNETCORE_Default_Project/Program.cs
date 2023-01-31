//WebApplicationBuilder -> Initializeren der WebAPP (Services in IOC legen) 
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

#region Initialisierung von Services 

// Add services to the container.
builder.Services.AddRazorPages(); //Intern werden für Logging, Static Files, HTTPS und HSTS, Rounting etc...


//builder.Services.AddControllersWithViews(); //MVC 
//builder.Services.AddMvc(); //Mix von MVC und Razor Page


#endregion

WebApplication app = builder.Build();


#region Configuration unserer WebAPP 

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

//Routing Map - Endpoint
app.MapRazorPages(); //Eine Request localhost:12345/Index -> 
#endregion


// App wird ausgeführt 
app.Run();

