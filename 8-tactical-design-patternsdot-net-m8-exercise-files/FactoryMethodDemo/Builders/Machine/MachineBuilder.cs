using FactoryMethodDemo.Builders.Machine.Interfaces;
using FactoryMethodDemo.Models;

namespace FactoryMethodDemo.Builders.Machine
{
    public class MachineBuilder :
        IProducerHolder, IModelHolder, IOwned, IMachineBuilder
    {
        private Producer Producer { get; set; }
        private string Model { get; set; }
        private LegalEntity Owner { get; set; }

        private MachineBuilder() { }

        private MachineBuilder(MachineBuilder other)
        {
            this.Producer = other.Producer;
            this.Model = other.Model;
            this.Owner = other.Owner;
        }

        public static IProducerHolder Machine() => new MachineBuilder();

        public IModelHolder WithProducer(Producer producer) =>
            new MachineBuilder()
            {
                Producer = producer
            };

        public IOwned WithModel(string model) =>
            new MachineBuilder(this)
            {
                Model = model
            };

        public IMachineBuilder OwnedBy(LegalEntity company) =>
            new MachineBuilder(this)
            {
                Owner = company
            };

        public Models.Machine Build() =>
            new Models.Machine(this.Producer, this.Model, this.Owner);

    }
}
