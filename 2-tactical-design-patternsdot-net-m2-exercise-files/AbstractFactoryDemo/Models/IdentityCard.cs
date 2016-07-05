using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    class IdentityCard: IUserIdentity
    {
        public string SSN { get; set; }
    }
}
