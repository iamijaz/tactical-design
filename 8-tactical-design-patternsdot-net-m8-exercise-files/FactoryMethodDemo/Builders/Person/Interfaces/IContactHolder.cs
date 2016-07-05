using System.Diagnostics.Contracts;
using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Builders.Person.Interfaces
{
    public interface IContactHolder
    {
        [Pure]
        bool Contains(IContactInfo contact);
    }
}