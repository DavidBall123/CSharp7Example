using System;
using Seterlund.CodeGuard;

namespace CSharp7Examples.Tuples
{
    public class Person: IPerson, IDisposable
    {
        private readonly (string FirstName, string LastName, int Age) _personDetails;

        public Person(string firstName, string lastName, int age)
        {
            Guard.That(firstName).IsNotNullOrEmpty();
            Guard.That(lastName).IsNotNullOrEmpty();
            Guard.That(age).IsInRange(1,150);

            _personDetails.Item1 = firstName;
            _personDetails.Item2 = lastName;
            _personDetails.Item3 = age;
        }

        public void Dispose()
        {
        }

        public (string FirstName, string LastName, int Age) GetPersonDetails()
        {
            return (_personDetails);
        }
    }
}
