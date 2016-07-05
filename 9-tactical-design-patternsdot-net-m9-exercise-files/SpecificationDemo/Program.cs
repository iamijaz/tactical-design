using System;
using SpecificationDemo.Interfaces;
using SpecificationDemo.Specifications.ContactInfo;
using SpecificationDemo.Specifications.EmailAddress;
using SpecificationDemo.Specifications.LegalEntity;
using SpecificationDemo.Specifications.PhoneNumber;
using SpecificationDemo.Specifications.Producer;
using SpecificationDemo.Specifications.User;

namespace SpecificationDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            IUser user =
                UserSpecification
                    .ForMachine()
                    .ProducedBy(
                        ProducerSpecification
                            .WithName("Big Co."))
                    .WithModel("Shiny one")
                    .OwnedBy(
                        LegalEntitySpecification
                            .Initialize()
                            .WithCompanyName("Properties Co.")
                            .WithEmailAddress(
                                ContactSpecification.ForEmailAddress("one@prop"))
                            .WithPhoneNumber(
                                ContactSpecification
                                    .ForPhoneNumber()
                                    .WithCountryCode(1)
                                    .WithAreaCode(23)
                                    .WithNumber(456))
                            .WithOtherContact(
                                ContactSpecification.ForEmailAddress("two@prop"))
                            .AndNoMoreContacts())
                    .Build();

            Console.WriteLine(user);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
