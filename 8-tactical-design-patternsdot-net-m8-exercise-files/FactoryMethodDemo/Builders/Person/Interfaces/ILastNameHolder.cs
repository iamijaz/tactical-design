using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Person.Contracts;

namespace FactoryMethodDemo.Builders.Person.Interfaces
{
    [ContractClass(typeof(LastNameHolderContracts))]
    public interface ILastNameHolder
    {
        IPrimaryContactHolder WithLastName(string surname);
        [Pure]
        bool IsValidLastName(string surname);
    }
}