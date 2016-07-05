using System;
using AbstractFactoryDemo.Factories.Interfaces;
using AbstractFactoryDemo.Factories.Person;
using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo
{
    class Program
    {

        static void ConfigureUser()
        {
            
            IUserFactory factory = new PersonFactory();

            IUser user = factory.CreateUser("Max", "Planck");

            IUserIdentity id = factory.CreateIdentity();

            user.SetIdentity(id);

        }

        static void Main(string[] args)
        {

            ConfigureUser();

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadLine();
        }
    }
}
