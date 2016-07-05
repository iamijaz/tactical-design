using System;
using System.Collections.Generic;
using System.Linq;
using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Models
{
    public class Person: IUser
    {
        public string Name { get; }
        public string Surname { get; }

        private IList<IContactInfo> Contacts { get; } = new List<IContactInfo>();
        public IContactInfo PrimaryContact { get; private set; }

        public Person(string name, string surname)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException();
            if (string.IsNullOrEmpty(surname))
                throw new ArgumentException();

            this.Name = name;
            this.Surname = surname;
        }

        public void SetIdentity(IUserIdentity identity) { }

        public bool CanAcceptIdentity(IUserIdentity identity) =>
            identity is IdentityCard;

        public void Add(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();

            if (this.Contacts.Contains(contact))
                throw new ArgumentException();

            this.Contacts.Add(contact);

        }

        public void SetPrimaryContact(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();

            if (!this.Contacts.Contains(contact))
                throw new ArgumentException();

            this.PrimaryContact = contact;

        }

        public override string ToString() =>
            $"{this.Name} {this.Surname} [{this.AllContactsLabel}]";

        private string AllContactsLabel =>
            string.Join(", ", this.AllContactLabels.ToArray());

        private IEnumerable<string> AllContactLabels =>
            this.Contacts.Select(this.GetLabelFor);

        private string GetLabelFor(IContactInfo contact) =>
            $"{GetUiMarkFor(contact)}{contact}";

        private string GetUiMarkFor(IContactInfo contact) => 
            this.IsPrimary(contact) ? "*" : string.Empty;

        private bool IsPrimary(IContactInfo contact) => contact.Equals(this.PrimaryContact);

    }
}
