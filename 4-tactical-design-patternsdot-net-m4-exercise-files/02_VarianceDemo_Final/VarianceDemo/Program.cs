using AbstractFactoryDemo.Factories.Interfaces;
using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo
{
    class Program
    {

        static void RegisterUser(IUserFactory userFactory)
        {
            IUser user = userFactory.CreateUser("Max", "Planck");

            IUserIdentity id = userFactory.CreateIdentity();
            user.SetIdentity(id);
        }

        static void Main(string[] args)
        {   
        }
    }
}
