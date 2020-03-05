namespace DDDTacticalPatterns.EventSourcingSample
{
    public interface IPersonRepository
    {
        Person Get(int id);

        Person Get(int id, int verion);
    }
}