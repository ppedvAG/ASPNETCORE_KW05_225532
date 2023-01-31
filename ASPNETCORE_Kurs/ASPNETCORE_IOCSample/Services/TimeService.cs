namespace ASPNETCORE_IOCSample.Services
{
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
