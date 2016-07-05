using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Person.Contracts;
using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Builders.Person.Interfaces
{
    [ContractClass(typeof(SecondaryContactHolderContracts))]
    public interface ISecondaryContactHolder : IContactHolder
    {
        ISecondaryContactHolder WithSecondaryContact(IContactInfo contact);
        IPersonBuilder AndNoMoreContacts();
    }
}