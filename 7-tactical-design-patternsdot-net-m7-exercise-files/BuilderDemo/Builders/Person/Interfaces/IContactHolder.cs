using System.Diagnostics.Contracts;
using BuilderDemo.Interfaces;

namespace BuilderDemo.Builders.Person.Interfaces
{
    public interface IContactHolder
    {
        [Pure]
        bool Contains(IContactInfo contact);
    }
}