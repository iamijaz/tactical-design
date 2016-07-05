using System;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    public class Machine: IUser
    {
        public Producer Producer { get; }
        public string Model { get; }

        public Machine(Producer producer, string model)
        {
            if (producer == null)
                throw new ArgumentNullException(nameof(producer));
            if (string.IsNullOrEmpty(model))
                throw new ArgumentException("Model name must be non-empty.");

            this.Producer = producer;
            this.Model = model;
        }

        public void SetIdentity(IUserIdentity identity)
        {
            throw new System.NotImplementedException();
        }
    }
}
