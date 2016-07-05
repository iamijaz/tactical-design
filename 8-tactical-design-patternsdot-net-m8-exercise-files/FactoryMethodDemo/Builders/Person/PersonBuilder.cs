using System.Collections.Generic;
using FactoryMethodDemo.Builders.Person.Interfaces;
using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Builders.Person
{
    public class PersonBuilder :
        IFirstNameHolder, ILastNameHolder, IPrimaryContactHolder, 
        ISecondaryContactHolder, IPersonBuilder

    {

        private string FirstName { get; set; }
        private string LastName { get; set; }
        private IList<IContactInfo> Contacts { get; set; } = new List<IContactInfo>();
        private IContactInfo PrimaryContact { get; set; }

        public static IFirstNameHolder Person() => new PersonBuilder();

        public ILastNameHolder WithFirstName(string firstName) =>
            new PersonBuilder()
            {
                FirstName = firstName
            };

        public bool IsValidFirstName(string name) => !string.IsNullOrEmpty(name);

        public IPrimaryContactHolder WithLastName(string lastName) =>
            new PersonBuilder()
            {
                FirstName = this.FirstName,
                LastName = lastName
            };

        public bool IsValidLastName(string surname) => !string.IsNullOrEmpty(surname);

        public ISecondaryContactHolder WithSecondaryContact(IContactInfo contact) =>
            this.WithContact(contact);

        private PersonBuilder WithContact(IContactInfo contact) =>
            new PersonBuilder()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Contacts = new List<IContactInfo>(this.Contacts) { contact },
                PrimaryContact = this.PrimaryContact
            };

        public IPersonBuilder AndNoMoreContacts() => this;

        public bool Contains(IContactInfo contact) => this.Contacts.Contains(contact);

        public ISecondaryContactHolder WithPrimaryContact(IContactInfo contact)
        {
            PersonBuilder builder = this.WithContact(contact);
            builder.PrimaryContact = contact;
            return builder;
        }

        public Models.Person Build()
        {

            Models.Person person = new Models.Person(this.FirstName, this.LastName);

            foreach (IContactInfo contact in this.Contacts)
                person.Add(contact);

            person.SetPrimaryContact(this.PrimaryContact);

            return person;

        }

    }
}
