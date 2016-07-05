using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Person.Contracts;

namespace FactoryMethodDemo.Builders.Person.Interfaces
{
    [ContractClass(typeof(FirstNameHolderContracts))]
    public interface IFirstNameHolder
    {
        ILastNameHolder WithFirstName(string name);
        [Pure]
        bool IsValidFirstName(string name);
    }
}
