using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Seterlund.CodeGuard;

namespace CSharp7Examples
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public Person(string firstName, string lastName, int age)
        {
            Guard.That(firstName).IsNotNullOrEmpty();
            Guard.That(firstName).IsNotNullOrEmpty();
            Guard.That(age).IsInRange(0, 150);

            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }
    }
}