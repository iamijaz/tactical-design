using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Machine.Contracts;
using FactoryMethodDemo.Models;

namespace FactoryMethodDemo.Builders.Machine.Interfaces
{
    [ContractClass(typeof(OwnedContracts))]
    public interface IOwned
    {
        IMachineBuilder OwnedBy(LegalEntity company);
    }
}