using AbstractFactoryDemo.Factories.Interfaces;
using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Factories.Person
{
    public class PersonFactory: IUserFactory<Models.Person, IdentityCard>
    {
        public Models.Person CreateUser(string name1, string name2)
        {
            return new Models.Person(name1, name2);
        }

        public IUserIdentity CreateIdentity()
        {
            return new IdentityCard();
        }
    }
}
