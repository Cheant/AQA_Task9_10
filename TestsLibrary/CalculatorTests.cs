using System;
using NUnit.Framework;
using CalculatorLibrary;

namespace TestsLibrary
{
    [TestFixture]
    public class CalculatorTests
    {
        private double _x ;
        private double _y;
        private double _expected;
        private double _actual;

        Calculator calculator = new Calculator();

        [SetUp]
        public void SetUp()
        {
            _x = 8;
            _y = 2;
        }

        [TearDown]
        public void TearDown()
        {
            _x = 0;
            _y = 0;
        }

        [Test]
        public void Add_8and2_10returned()
        {
            _expected = 10;

            _actual = calculator.Add(_x, _y);

            Assert.AreEqual(_expected, _actual);
        }

        [Test]
        public void Subtract_8and2_6returned()
        {
            _expected = 6;

            _actual = calculator.Subtract(_x, _y);

            Assert.AreEqual(_expected, _actual);
        }

        [Test]
        public void Multiply_8and2_16returned()
        {
            _expected = 16;

            _actual = calculator.Multiply(_x, _y);

            Assert.AreEqual(_expected, _actual);
        }

        [Test]
        public void Divide_8and2_4returned()
        {
            _expected = 4;

            _actual = calculator.Divide(_x, _y);

            Assert.AreEqual(_expected, _actual);
        }

        [Test]
        public void Divide_8and0_0returned()
        {
            _y = 0;
            _expected = 1;

            _actual = calculator.Divide(_x, _y);

            Assert.AreEqual(_expected, _actual);
        }

        [Test]
        public void Divide_8and2_IsNaN()
        {
            _actual = calculator.Divide(_x, _y);

            Assert.IsNaN(_actual);
        }

        [Test]
        public void Divide_8and2_IsEmpty()
        {
            _actual = calculator.Divide(_x, _y);

            Assert.IsEmpty(_actual.ToString());
        }

        [Test]
        public void Divide_8and2_AreNotSame()
        {
            _expected = 4;

            _actual = calculator.Divide(_x, _y);

            object expected = _expected;
            object actual = _actual;

            Assert.AreNotSame(actual, expected);
        }
    }
}
