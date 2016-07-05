namespace FactoryMethodDemo.Interfaces
{
    public interface IUser
    {
        IContactInfo PrimaryContact { get; }
        void SetIdentity(IUserIdentity identity);
        bool CanAcceptIdentity(IUserIdentity identity);
        void Add(IContactInfo contact);
        void SetPrimaryContact(IContactInfo contact);
    }
}
