using System;
using System.Diagnostics.Contracts;
using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Models
{
    public class Machine : IUser
    {
        public Producer Producer { get; set; }
        public string Model { get; set; }
        private LegalEntity Owner { get; }
        public IContactInfo PrimaryContact => this.Owner.EmailAddress;

        public Machine(Producer producer, string model, LegalEntity owningBusiness)
        {
            Contract.Requires<ArgumentNullException>(producer != null);
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(model));
            Contract.Requires<ArgumentNullException>(owningBusiness != null);

            this.Producer = producer;
            this.Model = model;
            this.Owner = owningBusiness;
        }

        public void SetIdentity(IUserIdentity identity)
        {
        }

        public bool CanAcceptIdentity(IUserIdentity identity)
        {
            return identity is MacAddress;
        }

        public void SetPrimaryContact(IContactInfo contact)
        {   // NOTE: It would be better to throw if contact is not email address
            // but that requires a new Boolean method like IsValidPrimaryContact
            // so that code contract can be implemented properly

            EmailAddress emailAddress = contact as EmailAddress;
            if (emailAddress == null)
                this.Owner.Add(contact);
            else
                this.Owner.SetEmailAddress(emailAddress);
        }

        public void Add(IContactInfo contact)
        {
            this.Owner.Add(contact);
        }

    }
}
