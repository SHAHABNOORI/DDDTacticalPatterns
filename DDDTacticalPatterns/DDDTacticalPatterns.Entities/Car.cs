namespace DDDTacticalPatterns.Entities
{
    public class Car
    {
        public Car(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public void ChangeName(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                throw new CarNameInvalidException();
            }
            Name = newName;
        }
    }
}