using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Person.Contracts;
using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Builders.Person.Interfaces
{
    [ContractClass(typeof(PrimaryContactHolderContracts))]
    public interface IPrimaryContactHolder : IContactHolder
    {
        ISecondaryContactHolder WithPrimaryContact(IContactInfo contact);
    }
}