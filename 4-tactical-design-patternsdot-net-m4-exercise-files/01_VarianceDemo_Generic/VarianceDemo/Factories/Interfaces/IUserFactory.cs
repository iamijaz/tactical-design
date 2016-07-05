using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Factories.Interfaces
{
    public interface IUserFactory<out TUser, in TIdentity>
        where TUser: IUser<TIdentity>
        where TIdentity: IUserIdentity
    {
        TUser CreateUser(string name1, string name2);
    }
}
