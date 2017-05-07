using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace CSharp7Examples.Test
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void WhenConstructedWithValidArgumentsNoExceptionIsThrown()
        {
            Action action = () =>
            {
                using (new Person("First Name", "Last Name", 6))
                {
                }
            };

            action.ShouldNotThrow();
        }

        [TestMethod]
        public void WhenConstructedWithNullFirstNameThrowsException()
        {
            Action action = () =>
            {
                using (new Person(null, "Last Name", 6))
                {
                }
            };

            action.ShouldThrow<ArgumentException>().WithMessage("String is null or empty");
        }

        [TestMethod]
        public void WhenConstructedWithEmptyFirstNameThrowsException()
        {
            Action action = () =>
            {
                using (new Person(string.Empty, "Last Name", 6))
                {
                }
            };

            action.ShouldThrow<ArgumentException>().WithMessage("String is null or empty");
        }

        [TestMethod]
        public void WhenConstructedWithNullLastNameThrowsException()
        {
            Action action = () =>
            {
                using (new Person("Fist Name", null, 6))
                {
                }
            };

            action.ShouldThrow<ArgumentException>().WithMessage("String is null or empty");
        }

        [TestMethod]
        public void WhenConstructedWithEmptyLastNameThrowsException()
        {
            Action action = () =>
            {
                using (new Person("Fist Name", string.Empty, 6))
                {
                }
            };

            action.ShouldThrow<ArgumentException>().WithMessage("String is null or empty");
        }

        [TestMethod]
        public void WhenConstructedWithAgeBelowLowRangeThrowsException()
        {
            Action action = () =>
            {
                using (new Person("Fist Name", "Last Name", -1))
                {
                }
            };

            action.ShouldThrow<ArgumentException>().WithMessage("Specified argument was out of the range of valid values.");
        }

        [TestMethod]
        public void WhenConstructedWithAgeAboveHightRangeThrowsException()
        {
            Action action = () =>
            {
                using (new Person("Fist Name", "Last Name", 151))
                {
                }
            };

            action.ShouldThrow<ArgumentException>().WithMessage("Specified argument was out of the range of valid values.");
        }

        [TestMethod]
        public void GetPersonDetailsReturnCorrectValues()
        {
            var personDetails = ("first name", "last name", 6);

            var target = new Person(personDetails.Item1, personDetails.Item2, personDetails.Item3);

            var actual = target.GetPersonDetails();

            actual.Should().Be(personDetails);
        }
    }
}
