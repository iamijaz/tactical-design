using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Models
{
    public class IdentityCard: IUserIdentity
    {
        public string SSN => "imagine one";
    }
}
