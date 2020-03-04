namespace DDDTacticalPatterns.Entities.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }
}