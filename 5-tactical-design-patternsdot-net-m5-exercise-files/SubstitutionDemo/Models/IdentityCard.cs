using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    public class IdentityCard: IUserIdentity
    {
        public string SSN => "imagine one";
    }
}
