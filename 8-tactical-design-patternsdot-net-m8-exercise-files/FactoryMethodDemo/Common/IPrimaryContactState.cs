using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Common
{
    public interface IPrimaryContactState
    {
        IPrimaryContactState Set(IContactInfo contact);
        IContactInfo Get();
    }
}
