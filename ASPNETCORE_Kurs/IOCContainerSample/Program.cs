using Microsoft.Extensions.DependencyInjection;

namespace IOCContainerSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialisierung Phase
            IServiceCollection services = new ServiceCollection();

            //Hinzufügen des TimeServices in den IOC Container
            services.AddSingleton<ITimeService, TimeService>();

            //Pro Anfrage (REquest) wird jedesmal das Objekt neu erstellt -> z.B EfCore verwendet AddScope
            //services.AddScoped<ITimeService, TimeService>();

            //Beim Zugriff auf den IOC Container (GetService oder GetRequiredService) wird das Objekt neu instanziiert 
            //services.AddTransient<ITimeService, TimeService>();

            //Initalisierungphase des IOC Containers ist mit dem Behfehl BuilderServiceProvier vorüber -> danach können keine weitere Services in den IOC Container geglegt werden
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            //Die Klasse ServiceProvider verwenden wir in ASP.NET Core direkt oder indirekt (siehe ASP.NET Core Beispiele) 
            #endregion


            #region Verwendung -> Seperation of Concerne (loose Kopplung) 
            //Hier greifen wir auf den IOC Container zu und bekomme eine fertige Instanz von TimeService-Klasse 
            //GetService vs. GetRequiredService (Wenn ein Dienst nicht gefunden wird, gibt GetService 'null' zurück und GetRequiredService eine Exception 
            ITimeService? timeService = serviceProvider.GetService<ITimeService>();
            ITimeService  timeService2 = serviceProvider.GetRequiredService<ITimeService>();

            Console.WriteLine(timeService.GetTime());

            #endregion
        }
    }

    public interface ITimeService
    {
        string GetTime();
    }

    public class TimeService : ITimeService
    {
        private string _time;

        //ctor + tab +tab 
        public TimeService()
        {
            _time = DateTime.Now.ToShortTimeString();
        }

        public string GetTime()
        {
            return _time;
        }
    }
}