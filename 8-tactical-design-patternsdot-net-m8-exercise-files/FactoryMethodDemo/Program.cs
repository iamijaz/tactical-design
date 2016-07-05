using System;
using FactoryMethodDemo.Builders.Machine;
using FactoryMethodDemo.Builders.Person;
using FactoryMethodDemo.Interfaces;
using FactoryMethodDemo.Models;

namespace FactoryMethodDemo
{
    class Program
    {

        static void ConfigureUser()
        {

            PersonalManager mgr = new PersonalManager(UserFactories.MachineFactory);
            mgr.Notify("hello");

        }

        static void Main(string[] args)
        {

            ConfigureUser();

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadLine();
        }
    }
}
