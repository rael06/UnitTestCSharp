using System;

namespace UnitTest
{
    public class CalculatorTdd
    {
        private readonly int _number1;
        private readonly int _number2;

        public CalculatorTdd(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public int Multiply() => _number1 * _number2;

        public double Divide() =>
            _number2 == 0 ? throw new DivideByZeroException() : (double) _number1 / _number2;
    }
}
