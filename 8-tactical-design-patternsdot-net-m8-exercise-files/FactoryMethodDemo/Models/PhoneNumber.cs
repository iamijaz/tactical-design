using System;
using System.Diagnostics.Contracts;
using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Models
{
    public class PhoneNumber : IContactInfo
    {

        private int CountryCode { get; }
        private int AreaCode { get; }
        private int Number { get; }

        public PhoneNumber(int countryCode, int areaCode, int number)
        {
            Contract.Requires<ArgumentException>(countryCode > 0);
            Contract.Requires<ArgumentException>(areaCode > 0);
            Contract.Requires<ArgumentException>(number > 0);

            this.CountryCode = countryCode;
            this.AreaCode = areaCode;
            this.Number = number;
        }

        public override string ToString() => $"+{this.CountryCode}({this.AreaCode}){this.Number}";

    }
}
