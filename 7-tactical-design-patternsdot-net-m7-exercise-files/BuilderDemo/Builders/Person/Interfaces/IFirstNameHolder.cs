using System.Diagnostics.Contracts;
using BuilderDemo.Builders.Person.Contracts;

namespace BuilderDemo.Builders.Person.Interfaces
{
    [ContractClass(typeof(FirstNameHolderContracts))]
    public interface IFirstNameHolder
    {
        ILastNameHolder WithFirstName(string name);
        [Pure]
        bool IsValidFirstName(string name);
    }
}
