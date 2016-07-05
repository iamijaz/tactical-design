namespace SpecificationDemo.Specifications
{
    public interface IBuildingSpecification<out T>
    {
        T Build();
    }
}
