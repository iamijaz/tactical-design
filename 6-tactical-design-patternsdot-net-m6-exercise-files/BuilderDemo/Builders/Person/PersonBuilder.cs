using System;
using BuilderDemo.Common;

namespace BuilderDemo.Builders.Person
{
    public class PersonBuilder
    {

        private INonEmptyStringState FirstNameState { get; set; } =
            new UninitializedString();

        private INonEmptyStringState LastNameState { get; set; } =
            new UninitializedString();

        public void SetFirstName(string firstName)
        {
            this.FirstNameState = this.FirstNameState.Set(firstName);
        }

        public void SetLastName(string lastName)
        {
            this.LastNameState = this.LastNameState.Set(lastName);
        }

        public Models.Person Build()
        {
            return new Models.Person(this.FirstNameState.Get(), this.LastNameState.Get());
        }

    }
}
