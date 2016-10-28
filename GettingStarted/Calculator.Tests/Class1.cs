using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));


        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Multiply(2, 10);

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void ShouldAddDouble()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddDoubles(1.1, 2.2);

            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        public void ShouldNotBeBiggerThan100()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddDoubles(1.1, 2.2);

            Assert.That(result, Is.Not.GreaterThan(100));
        }

        [Test]
        public void ShouldJoinNames()
        {
            var sut = new NameJoiner();

            var result = sut.Join("Sarah", "Smith");

            Assert.That(result, Is.EqualTo("Sarah Smith"));
        }

        [Test]
        public void ShouldJoinName_CaseInsentitiveAssertDemo()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("sarah", "smith");

            Assert.That(fullName, Is.EqualTo("SARAH SMITH").IgnoreCase);
        }

        [Test]
        public void ShouldJoinNames_NotEqualDemo()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            Assert.That(fullName, Is.Not.EqualTo("Gentry Smith"));
        }


    }
}
