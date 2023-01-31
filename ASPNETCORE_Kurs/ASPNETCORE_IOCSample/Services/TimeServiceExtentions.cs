namespace ASPNETCORE_IOCSample.Services
{
    public static class TimeServiceExtentions
    {
        public static void AddTimeSerivce(this IServiceCollection services)
        {
            services.AddScoped<ITimeService, TimeService>();
        }
    }
}
