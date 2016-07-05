using System.Diagnostics.Contracts;
using BuilderDemo.Builders.Person.Contracts;
using BuilderDemo.Interfaces;

namespace BuilderDemo.Builders.Person.Interfaces
{
    [ContractClass(typeof(SecondaryContactHolderContracts))]
    public interface ISecondaryContactHolder : IContactHolder
    {
        ISecondaryContactHolder WithSecondaryContact(IContactInfo contact);
        IPersonBuilder AndNoMoreContacts();
    }
}