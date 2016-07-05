using System.Diagnostics.Contracts;
using BuilderDemo.Builders.Person.Contracts;
using BuilderDemo.Interfaces;

namespace BuilderDemo.Builders.Person.Interfaces
{
    [ContractClass(typeof(PrimaryContactHolderContracts))]
    public interface IPrimaryContactHolder : IContactHolder
    {
        ISecondaryContactHolder WithPrimaryContact(IContactInfo contact);
    }
}