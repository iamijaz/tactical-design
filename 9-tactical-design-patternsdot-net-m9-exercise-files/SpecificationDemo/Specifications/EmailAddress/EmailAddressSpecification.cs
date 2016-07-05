using System;

namespace SpecificationDemo.Specifications.EmailAddress
{
    public class EmailAddressSpecification:
        Interfaces.IExpectAddress, IBuildingSpecification<Models.EmailAddress>
    {

        private string EmailAddress { get; set; }

        private EmailAddressSpecification() { }

        public static Interfaces.IExpectAddress Initialize() => 
            new EmailAddressSpecification();

        public IBuildingSpecification<Models.EmailAddress> WithAddress(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
                throw new ArgumentException();
            return new EmailAddressSpecification() {EmailAddress = emailAddress};
        }

        public Models.EmailAddress Build() =>
            new Models.EmailAddress()
            {
                Address = this.EmailAddress
            };

    }
}
