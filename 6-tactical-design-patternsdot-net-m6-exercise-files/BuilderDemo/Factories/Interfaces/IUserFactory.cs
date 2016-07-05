using BuilderDemo.Interfaces;

namespace BuilderDemo.Factories.Interfaces
{
    public interface IUserFactory
    {
        IUser CreateUser(string name1, string name2);
        IUserIdentity CreateIdentity();
    }
}
