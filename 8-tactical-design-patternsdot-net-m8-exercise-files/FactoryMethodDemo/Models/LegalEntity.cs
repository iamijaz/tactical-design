using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Models
{
    public class LegalEntity
    {

        public string CompanyName { get; }
        public EmailAddress EmailAddress { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        private IList<IContactInfo> OtherContacts { get; } = new List<IContactInfo>();

        public LegalEntity(string companyName, EmailAddress emailAddress, PhoneNumber phoneNumber)
        {
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(companyName));
            Contract.Requires<ArgumentNullException>(emailAddress != null);
            Contract.Requires<ArgumentNullException>(phoneNumber != null);

            this.CompanyName = companyName;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
        }

        public void SetEmailAddress(EmailAddress emailAddress)
        {
            Contract.Requires<ArgumentNullException>(emailAddress != null);
            this.EmailAddress = emailAddress;
        }

        public void SetPhoneNumber(PhoneNumber phoneNumber)
        {
            Contract.Requires<ArgumentNullException>(phoneNumber != null);
            this.PhoneNumber = phoneNumber;
        }

        public void Add(IContactInfo alternateContact)
        {
            Contract.Requires<ArgumentNullException>(alternateContact != null);
            Contract.Requires<ArgumentException>(!this.Contains(alternateContact));

            this.OtherContacts.Add(alternateContact);
        }

        [Pure]
        public bool Contains(IContactInfo contact)
        {
            return
                this.EmailAddress.Equals(contact) ||
                this.PhoneNumber.Equals(contact) ||
                this.OtherContacts.Contains(contact);
        }

    }
}
