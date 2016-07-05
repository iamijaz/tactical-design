using System;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    public class Machine: IUser
    {
        public Producer Producer { get; set; }
        public string Model { get; set; }

        public void SetIdentity(IUserIdentity identity)
        {
            // identity must be MacAddress
            // access identity.NicPart
        }

        public Machine(Producer producer, string model)
        {
            if (producer == null)
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(model))
                throw new ArgumentException();

            this.Producer = producer;
            this.Model = model;

        }
    }
}
