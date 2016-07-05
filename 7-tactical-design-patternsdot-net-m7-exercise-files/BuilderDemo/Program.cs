using System;
using BuilderDemo.Builders.Person;
using BuilderDemo.Interfaces;
using BuilderDemo.Models;

namespace BuilderDemo
{
    class Program
    {

        static void ConfigureUser()
        {

            Person person =
                PersonBuilder
                    .Person()
                    .WithFirstName("Max")
                    .WithLastName("Planck")
                    .WithPrimaryContact(new EmailAddress("max.planck@my-institute.com"))
                    .WithSecondaryContact(new EmailAddress("max@home-of-planck.com"))
                    .AndNoMoreContacts()
                    .Build();

            Console.WriteLine(person);
            Console.WriteLine();

        }

        static void Main(string[] args)
        {

            ConfigureUser();

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadLine();
        }
    }
}
