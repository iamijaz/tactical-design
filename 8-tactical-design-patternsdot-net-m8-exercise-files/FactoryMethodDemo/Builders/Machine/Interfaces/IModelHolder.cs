using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Machine.Contracts;

namespace FactoryMethodDemo.Builders.Machine.Interfaces
{
    [ContractClass(typeof(ModelHolderContracts))]
    public interface IModelHolder
    {
        IOwned WithModel(string model);
    }
}