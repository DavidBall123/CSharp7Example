using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seterlund.CodeGuard;

namespace CSharp7Examples
{
    public class Person: IPerson, IDisposable
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly int _age;
        public Person(string firstName, string lastName, int age)
        {
            Guard.That(firstName).IsNotNullOrEmpty();
            Guard.That(lastName).IsNotNullOrEmpty();
            Guard.That(age).IsInRange(1,150);

            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public void Dispose()
        {
        }

        public (string FirstName, string LastName, int Age) GetPersonDetails()
        {
            return (_firstName, _lastName, _age);
        }
    }
}
