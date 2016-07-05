using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Models
{
    public class MacAddress: IUserIdentity
    {
        public string NicPart { get; set; }
    }
}
