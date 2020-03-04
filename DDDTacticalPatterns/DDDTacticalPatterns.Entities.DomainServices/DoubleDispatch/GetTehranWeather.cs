using DDDTacticalPatterns.Entities.DomainServices.DoubleDispatch;

namespace DDDTacticalPatterns.Entities.DomainServices
{
    public class GetTehranWeather: IGetWeather
    {
        public int Get(Person person)
        {
            //Use Person Entity
            //Use Web Service
            return 10;
        }
    }
}