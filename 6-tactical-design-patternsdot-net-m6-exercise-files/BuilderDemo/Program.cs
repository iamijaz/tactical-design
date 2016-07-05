using System;
using BuilderDemo.Builders.Person;
using BuilderDemo.Models;

namespace BuilderDemo
{
    class Program
    {

        static void ConfigureUser()
        {
            PersonBuilder builder = new PersonBuilder();

            builder.SetFirstName("Max");
            builder.SetLastName("Planck");

            Person person = builder.Build();

            Console.WriteLine(person);
        }

        static void Main(string[] args)
        {

            ConfigureUser();

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadLine();
        }
    }
}
