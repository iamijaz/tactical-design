using System;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    public class Person : IUser
    {

        public string Name { get; }
        public string Surname { get; }

        public Person(string name, string surname)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("First name must be non-empty.");
            if (string.IsNullOrEmpty(surname))
                throw new ArgumentException("Last name must be non-empty.");

            this.Name = name;
            this.Surname = surname;
        }

        public void SetIdentity(IUserIdentity identity)
        {
        }

        public override string ToString() => $"{this.Name} {this.Surname}";
    }
}
