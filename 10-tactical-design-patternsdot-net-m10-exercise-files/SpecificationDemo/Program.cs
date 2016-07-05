using System;
using SpecificationDemo.Interfaces;
using SpecificationDemo.Models;
using SpecificationDemo.Specifications;
using SpecificationDemo.Specifications.ContactInfo;
using SpecificationDemo.Specifications.Person.Interfaces;
using SpecificationDemo.Specifications.User;

namespace SpecificationDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            IExpectAlternateContact spec =
                UserSpecification
                    .ForPerson()
                    .WithName("Max")
                    .WithSurname("Planck")
                    .WithPrimaryContact(
                        ContactSpecification.ForEmailAddress("max.planck@my-institute.com"));

            IBuildingSpecification<EmailAddress> contact =
                ContactSpecification.ForEmailAddress("max@home-of-plancks.com");

            if (!spec.CanAdd(contact))
            {
                Console.WriteLine("Cannot add desired contact...");
            }
            else
            {
                spec = spec.WithAlternateContact(contact);
                IUser user = spec.AndNoMoreContacts().Build();
                Console.WriteLine(user);
            }

            Console.ReadLine();
        }
    }
}
