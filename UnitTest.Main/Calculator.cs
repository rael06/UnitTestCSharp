namespace UnitTest
{
    public class Calculator
    {
        private readonly int _number1;
        private readonly int _number2;

        public Calculator(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public int Add() => _number1 + _number2;
        public int Subtract() => _number1 - _number2;
        public int Multiply() => _number1 * _number2;
        public int Divide() => _number1 / _number2;
    }
}
