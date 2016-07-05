using System;
using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Machine.Interfaces;

namespace FactoryMethodDemo.Builders.Machine.Contracts
{
    [ContractClassFor(typeof(IModelHolder))]
    public class ModelHolderContracts : IModelHolder
    {
        public IOwned WithModel(string model)
        {
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(model));
            return null;
        }
    }
}