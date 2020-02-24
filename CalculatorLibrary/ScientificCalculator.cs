using System;
using System.Linq;

namespace CalculatorLibrary
{
    public class ScientificCalculator : Calculator
    {
        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public double Percentage(double x, double y)
        {
            return (x / y) * 100;
        }

        public double Modulo(double x, double y)
        {
            return x % y;
        }

        public double ArraySum(double[] array)
        {
            return array.Sum();
        }

        public double ArrayMax(double[] array)
        {
            return array.Max();
        }

        public double ArrayMin(double[] array)
        {
            return array.Min();
        }
    }
}
