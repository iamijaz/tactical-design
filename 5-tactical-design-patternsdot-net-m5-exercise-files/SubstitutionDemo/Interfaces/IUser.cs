namespace AbstractFactoryDemo.Interfaces
{
    public interface IUser: ITicketHolder
    {
        void SetIdentity(IUserIdentity identity);
        bool CanAcceptIdentity(IUserIdentity identity);
    }
}
