using System;
using System.Globalization;
using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Models
{
    public class EmailAddress: IContactInfo
    {
        private string Address { get; }

        public EmailAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
                throw new ArgumentException();
            this.Address = address;
        }

        public override int GetHashCode() => this.Address.ToLower().GetHashCode();

        public override bool Equals(object obj)
        {
            EmailAddress email = obj as EmailAddress;

            if (email == null)
                return false;

            return string.Compare(this.Address, email.Address, 
                                  true, CultureInfo.InvariantCulture) == 0;

        }

        public override string ToString() => $"{this.Address}";

    }
}
