using System.Diagnostics.Contracts;
using BuilderDemo.Builders.Person.Interfaces;

namespace BuilderDemo.Builders.Person.Contracts
{
    [ContractClassFor(typeof(ILastNameHolder))]
    public abstract class LastNameHolderContracts : ILastNameHolder
    {
        public abstract bool IsValidLastName(string surname);

        public IPrimaryContactHolder WithLastName(string surname)
        {
            Contract.Requires(this.IsValidLastName(surname));
            return null;
        }
    }
}