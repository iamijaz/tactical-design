using System.Diagnostics.Contracts;
using BuilderDemo.Builders.Person.Interfaces;
using BuilderDemo.Interfaces;

namespace BuilderDemo.Builders.Person.Contracts
{
    [ContractClassFor(typeof(IPrimaryContactHolder))]
    public abstract class PrimaryContactHolderContracts : IPrimaryContactHolder
    {
        public ISecondaryContactHolder WithPrimaryContact(IContactInfo contact)
        {
            Contract.Requires(contact != null);
            Contract.Requires(!this.Contains(contact));
            return null;
        }

        public abstract bool Contains(IContactInfo contact);
    }
}