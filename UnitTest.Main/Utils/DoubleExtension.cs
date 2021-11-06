using System;

namespace UnitTest.Utils
{
    public static class DoubleExtension
    {
        private const double _tolerance = 1E-15d;
        public static bool IsEqualWithToleranceTo(this double value1, double value2, double tolerance = _tolerance) =>
            Math.Abs(value1 - value2) < tolerance;

        public static bool IsGreaterWithToleranceThan(this double value1, double value2, double tolerance = _tolerance) =>
            value1 - value2 > -tolerance;

        public static bool IsGreaterOrEqualWithToleranceThan(this double value1, double value2, double tolerance = _tolerance) =>
            value1 - value2 >= -tolerance;

        public static bool IsLowerWithToleranceThan(this double value1, double value2, double tolerance = _tolerance) =>
            value1 - value2 < tolerance;

        public static bool IsLowerOrEqualWithToleranceThan(this double value1, double value2, double tolerance = _tolerance) =>
            value1 - value2 <= tolerance;
    }
}
