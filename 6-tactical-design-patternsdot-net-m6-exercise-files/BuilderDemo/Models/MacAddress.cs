using BuilderDemo.Interfaces;

namespace BuilderDemo.Models
{
    public class MacAddress: IUserIdentity
    {
        public string NicPart { get; set; }
    }
}
