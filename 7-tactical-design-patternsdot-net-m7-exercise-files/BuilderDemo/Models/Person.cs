using System;
using System.Collections.Generic;
using System.Linq;
using BuilderDemo.Interfaces;

namespace BuilderDemo.Models
{
    public class Person: IUser
    {
        public string Name { get; internal set; }
        public string Surname { get; internal set; }
        public IEnumerable<IContactInfo> Contacts => this.ContactsList;
        public IContactInfo PrimaryContact { get; internal set; }

        internal IList<IContactInfo> ContactsList { get; } = new List<IContactInfo>();

        internal Person() { }

        public void SetIdentity(IUserIdentity identity) { }

        public bool CanAcceptIdentity(IUserIdentity identity) =>
            identity is IdentityCard;

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
