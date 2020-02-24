using NUnit.Framework;
using CalculatorLibrary;

namespace TestsLibrary
{
    [TestFixture, Description("Test for Scientific Calculator")]
    public class ScientificCalculatorTests
    {
        private double _x = 8;
        private double _y = 2;
        private double _expected;
        private double _actual;
        private string _string = "String Assertion";

        ScientificCalculator scientificCalculator = new ScientificCalculator();

        [Test(ExpectedResult = 64), Description("Power test")]
        public double Pow_8and2_64returned()
        {
            return scientificCalculator.Power(_x, _y);
        }

        [Test(ExpectedResult = 400), Description("Percentage test")]
        public double Percentage_8and2_400returned()
        {
            return scientificCalculator.Percentage(_x, _y);
        }

        [Test, Timeout(10)]
        public void Modulo_8and2_0returned()
        {
            _expected = 0;

            _actual = scientificCalculator.Modulo(_x, _y);

            Assert.That(_actual, Is.EqualTo(_expected));
        }

        [Test, MaxTime(10)]
        public void ArraySum_1and7and2_10returned()
        {
            double[] array = { 1, 7, 2};
            _expected = 10;

            _actual = scientificCalculator.ArraySum(array);

            Assert.That(_actual, Is.EqualTo(_expected));
        }

        [Test, Order(1), Retry(3)]
        public void ArrayMax_1and7and2_10returned()
        {
            double[] array = { 1, 7, 2 };
            _expected = 7;

            _actual = scientificCalculator.ArrayMax(array);

            Assert.That(_actual, Is.EqualTo(_expected));
        }

        [Test, Repeat(3)]
        public void ArrayMin_1and7and2_10returned()
        {
            double[] array = { 1, 7, 2 };
            _expected = 1;

            _actual = scientificCalculator.ArrayMin(array);

            Assert.That(_actual, Is.EqualTo(_expected));
        }

        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(6, 6, ExpectedResult = 12)]
        [TestCase(1, -3, ExpectedResult = -2)]
        [TestCase(2.5, 100, ExpectedResult = 102.5)]
        [TestCase(2, 4, ExpectedResult = 5)]
        public double Add_TestCases(double x, double y)
        {
            return scientificCalculator.Add(x, y);
        }

        [Test]
        [Ignore("Ignore the test")]
        public void Subtract_8and2_6returned()
        {
            _expected = 6;

            _actual = scientificCalculator.Subtract(_x, _y);

            Assert.That(_actual, Is.EqualTo(_expected));
        }

        [Test]
        public void StringContainAssertion()
        {
            Assert.That(_string, Does.Contain("ass").IgnoreCase);
        }

        [Test]
        public void StringStartWithAssertion()
        {
            Assert.That(_string, Does.StartWith("str").IgnoreCase);
        }

        [Test]
        public void StringIsEqualToAssertion()
        {
            Assert.That(_string, Is.EqualTo("string assertion").IgnoreCase);
        }
    }
}
