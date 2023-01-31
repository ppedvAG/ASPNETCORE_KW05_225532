namespace ASPNETCORE_IOCSample.Services
{
    public class TimeService2 : ITimeService
    {
        private string _time;

        //ctor + tab +tab 
        public TimeService2()
        {
            _time = DateTime.Now.ToShortTimeString();
        }

        public string GetTime()
        {
            return _time;
        }
    }
}
