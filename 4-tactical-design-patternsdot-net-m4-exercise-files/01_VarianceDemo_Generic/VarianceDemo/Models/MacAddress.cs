using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    public class MacAddress: IUserIdentity
    {
        public string NicPart { get; set; }
    }
}
