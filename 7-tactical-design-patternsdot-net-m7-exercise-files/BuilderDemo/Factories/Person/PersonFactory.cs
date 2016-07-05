using BuilderDemo.Factories.Interfaces;
using BuilderDemo.Interfaces;
using BuilderDemo.Models;

namespace BuilderDemo.Factories.Person
{
    public class PersonFactory: IUserFactory
    {
        public IUser CreateUser(string name1, string name2)
        {
            Models.Person person = new Models.Person();
            person.Name = name1;
            person.Surname = name2;
            return person;
        }

        public IUserIdentity CreateIdentity()
        {
            return new IdentityCard();
        }
    }
}
