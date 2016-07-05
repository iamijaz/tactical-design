using SpecificationDemo.Interfaces;

namespace SpecificationDemo.Specifications.Person.Interfaces
{
    public interface IExpectPrimaryContact
    {
        IExpectAlternateContact WithPrimaryContact(IBuildingSpecification<IContactInfo> primaryContactSpec);
    }
}