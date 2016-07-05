using System.Diagnostics.Contracts;
using BuilderDemo.Builders.Person.Contracts;

namespace BuilderDemo.Builders.Person.Interfaces
{
    [ContractClass(typeof(LastNameHolderContracts))]
    public interface ILastNameHolder
    {
        IPrimaryContactHolder WithLastName(string surname);
        [Pure]
        bool IsValidLastName(string surname);
    }
}