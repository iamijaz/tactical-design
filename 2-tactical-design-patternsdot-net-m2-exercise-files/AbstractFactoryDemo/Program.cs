using System;
using AbstractFactoryDemo.Factories.Interfaces;
using AbstractFactoryDemo.Factories.Person;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo
{
    class Program
    {

        static void RegisterUser(IUserFactory userFactory)
        {
            IUser user = userFactory.CreateUser("Max", "Planck");
            Console.WriteLine("Hello {0}, welcome back!", user);
        }

        static void Main(string[] args)
        {   
            RegisterUser(new PersonFactory());
            Console.ReadLine();
        }
    }
}
