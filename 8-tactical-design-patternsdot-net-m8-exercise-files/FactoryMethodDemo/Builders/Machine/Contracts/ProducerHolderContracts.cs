using System;
using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Machine.Interfaces;
using FactoryMethodDemo.Models;

namespace FactoryMethodDemo.Builders.Machine.Contracts
{
    [ContractClassFor(typeof(IProducerHolder))]
    public abstract class ProducerHolderContracts : IProducerHolder
    {
        public IModelHolder WithProducer(Producer producer)
        {
            Contract.Requires<ArgumentNullException>(producer != null);
            return null;
        }
    }
}