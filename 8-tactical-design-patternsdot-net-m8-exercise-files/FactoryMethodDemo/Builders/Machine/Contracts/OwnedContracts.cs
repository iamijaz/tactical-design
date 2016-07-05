using System;
using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Machine.Interfaces;
using FactoryMethodDemo.Models;

namespace FactoryMethodDemo.Builders.Machine.Contracts
{
    [ContractClassFor(typeof(IOwned))]
    public abstract class OwnedContracts : IOwned
    {
        public IMachineBuilder OwnedBy(LegalEntity company)
        {
            Contract.Requires<ArgumentNullException>(company != null);
            return null;
        }
    }
}