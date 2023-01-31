using ASPNETCORE_Configuration_and_Logging.Configurations;
using Serilog;

namespace ASPNETCORE_Configuration_and_Logging
{
    public class Program
    {
        public static void Main(string[] args)
        {



            //Auslesen der AppSettings.JSON 
            var builder = WebApplication.CreateBuilder(args);

            //LOGGING SAMPLE
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<Program>(optional: true)
                .AddEnvironmentVariables()
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            builder.Host.UseSerilog();




            //CONFIGURATION SAMPLES
            builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile("GameSettings.json", true, true);
                //config.AddXmlFile
                //config.AddIniFile
            });


            //Ab hier ist die GameSettings in IConfiguration geladen
            //Wir mappen die GameSettings-Section (von JSON-Datei) in die GameSettings-Klasse 

            builder.Services.Configure<GameSettings>(builder.Configuration.GetSection("GameSettings"));




           

            // Add services to the container.
            builder.Services.AddRazorPages();

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

            try
            {
                app.Run();
            }
            catch (Exception ex)
            {
                Log.Information(ex.ToString());
            }
            finally
            {
                //Schreibe alles noch raus, was sich im Speicher vom Logger befindet 
                Log.CloseAndFlush();
            }
            
        }
    }
}