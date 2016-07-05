using AbstractFactoryDemo.Factories.Interfaces;
using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo
{
    class Program
    {

        static void RegisterUser(IUserFactory<Person, IdentityCard> userFactory)
        {
            IUserFactory<Person, BillMurrayCard> lessDerivedFactory = userFactory;
        }

        static void Main(string[] args)
        {   
        }
    }
}
