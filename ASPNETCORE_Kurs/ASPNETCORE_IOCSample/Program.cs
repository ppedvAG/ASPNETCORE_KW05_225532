using ASPNETCORE_IOCSample.Services;

namespace ASPNETCORE_IOCSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            //builder.Services.AddSingleton<ITimeService, TimeService
            //

            //Mulitple Implenentierungen -> one interface
            //builder.Services.AddScoped<ITimeService, TimeService>();
            //builder.Services.AddSingleton<ITimeService, TimeService2>();
            //builder.Services.AddTransient<ITimeService, TimeService2>();

            builder.Services.AddTimeSerivce(); //Ist ein Scope

           
            //Initialisierungphase des IOC Container ist mit builder.Build zueende 
            var app = builder.Build();


            using (IServiceScope scope = app.Services.CreateScope())
            {
                ITimeService timeService3 = scope.ServiceProvider.GetService<ITimeService>();
                ITimeService timeService4 = scope.ServiceProvider.GetRequiredService<ITimeService>();
            }


            ////Neuere Variante - Achtung bei Scope Lifetimes -> Wirf eine Exception
            //ITimeService timeService1 = app.Services.GetService<ITimeService>();    
            //ITimeService timeService2 = app.Services.GetRequiredService<ITimeService>();    


            //ab ASP.NET Core 2.1 - Interessant für EF Core (ist ein Scope), wenn man Testdaten benötigt

            



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

            app.MapRazorPages(); //Navigation 

            app.Run();
        }
    }
}