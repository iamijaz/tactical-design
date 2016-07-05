using SpecificationDemo.Interfaces;

namespace SpecificationDemo.Specifications.Person.Interfaces
{
    public interface IExpectAlternateContact
    {
        IExpectAlternateContact WithAlternateContact(IBuildingSpecification<IContactInfo> contactSpec);
        IBuildingSpecification<Models.Person> AndNoMoreContacts();
    }
}