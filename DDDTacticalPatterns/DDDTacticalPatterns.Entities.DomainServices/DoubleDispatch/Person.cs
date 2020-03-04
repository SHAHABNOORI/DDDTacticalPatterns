using DDDTacticalPatterns.Entities.DomainServices.DoubleDispatch;

namespace DDDTacticalPatterns.Entities.DomainServices
{
    public class Person
    {
        public string FirsName { get; set; }

        public string LastName { get; set; }

        public int GetWeather(IGetWeather getWeather)
        {
            return getWeather.Get(this);
        }
    }
}