using System;
using System.Collections.Generic;
using SpecificationDemo.Interfaces;
using System.Linq;
using SpecificationDemo.Specifications.Person.Interfaces;

namespace SpecificationDemo.Specifications.Person
{
    public class PersonSpecification:
        IExpectName, IExpectSurname,
        IExpectPrimaryContact, IExpectAlternateContact,
        IBuildingSpecification<Models.Person>
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private IEnumerable<IBuildingSpecification<IContactInfo>> ContactSpecs { get; set; }
        private IBuildingSpecification<IContactInfo> PrimaryContactSpec { get; set; }

        private PersonSpecification() { }

        public static IExpectName Initialize() => new PersonSpecification();

        public IExpectSurname WithName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException();

            return new PersonSpecification()
            {
                Name = name
            };
        }

        public IExpectPrimaryContact WithSurname(string surname)
        {
            if (string.IsNullOrEmpty(surname))
                throw new ArgumentException();

            return new PersonSpecification()
            {
                Name = this.Name,
                Surname = surname
            };
        }

        public IExpectAlternateContact WithPrimaryContact(IBuildingSpecification<IContactInfo> primaryContactSpec)
        {
            if (primaryContactSpec == null)
                throw new ArgumentNullException();

            return new PersonSpecification()
            {
                Name = this.Name,
                Surname = this.Surname,
                ContactSpecs = new[] { primaryContactSpec },
                PrimaryContactSpec = primaryContactSpec
            };
        }

        public IExpectAlternateContact WithAlternateContact(IBuildingSpecification<IContactInfo> contactSpec)
        {
            if (contactSpec == null)
                throw new ArgumentNullException();

            return new PersonSpecification()
            {
                Name = this.Name,
                Surname = this.Surname,
                ContactSpecs = new List<IBuildingSpecification<IContactInfo>>(this.ContactSpecs) {contactSpec},
                PrimaryContactSpec = this.PrimaryContactSpec
            };
        }

        public IBuildingSpecification<Models.Person> AndNoMoreContacts() => this;

        public Models.Person Build() =>
            new Models.Person()
            {
                Name = this.Name,
                Surname = this.Surname,
                PrimaryContact = this.PrimaryContactSpec.Build(),
                ContactsList = this.ContactSpecs.Select(spec => spec.Build()).ToList()
            };
    }
}
