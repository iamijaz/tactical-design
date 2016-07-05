using System;
using System.Collections.Generic;
using AbstractFactoryDemo.Factories.Interfaces;
using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Factories.Machine
{
    public class MachineFactory : IUserFactory
    {

        private Dictionary<string, Producer> NameToProducer { get; }

        public MachineFactory(Dictionary<string, Producer> nameToProducer)
        {
            if (nameToProducer == null)
                throw new ArgumentNullException(nameof(nameToProducer));
            this.NameToProducer = nameToProducer;
        }

        private Producer GetProducer(string name)
        {
            Producer producer;
            if (!this.NameToProducer.TryGetValue(name, out producer))
                throw new ArgumentException();
            return producer;
        }

        public IUser CreateUser(string name1, string name2)
        {
            Producer producer = this.GetProducer(name1);
            return new Models.Machine(producer, name2);
        }

        public IUserIdentity CreateIdentity()
        {
            return new MacAddress();
        }
    }
}
