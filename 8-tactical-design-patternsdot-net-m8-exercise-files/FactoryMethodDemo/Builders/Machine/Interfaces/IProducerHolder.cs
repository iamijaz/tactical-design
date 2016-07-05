using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Machine.Contracts;
using FactoryMethodDemo.Models;

namespace FactoryMethodDemo.Builders.Machine.Interfaces
{
    [ContractClass(typeof(ProducerHolderContracts))]
    public interface IProducerHolder
    {
        IModelHolder WithProducer(Producer producer);
    }
}
