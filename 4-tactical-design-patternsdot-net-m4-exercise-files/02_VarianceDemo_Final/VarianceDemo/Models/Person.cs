using System;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    public class Person: IUser
    {
        private string name;
        private string surname;

        public void SetIdentity(IUserIdentity identity)
        {
            // identity must be IdentityCard
            // access identity.SSN
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First name must be non-empty.");
                this.name = value;
            }
        }

        public string Surname
        {
            get { return this.surname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name must be non-empty;");
                this.surname = value;
            }
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

    }
}
