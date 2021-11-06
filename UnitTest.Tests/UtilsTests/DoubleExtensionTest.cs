using UnitTest.Utils;
using Xunit;

namespace UnitTest.Tests.UtilsTests
{
    public class DoubleExtensionTest
    {
        // Arrange
        const double lowestDouble = 21 / 100d;
        const double greatestDouble = 2.1 / 10d;

        [Fact]
        public void Should_Return_True_When_Double1_IsGreaterWithToleranceThan_Double2()
        {
            Assert.False(lowestDouble.IsEqualWithToleranceTo(greatestDouble, 0));
            // with default tolerance
            Assert.True(lowestDouble.IsEqualWithToleranceTo(greatestDouble));
        }

        [Fact]
        public void Test_IsGreaterOrEqualWithToleranceThan()
        {
            Assert.True(greatestDouble.IsGreaterOrEqualWithToleranceThan(lowestDouble, 0));
            Assert.False(lowestDouble.IsGreaterOrEqualWithToleranceThan(greatestDouble, 0));

            const double tolerance = greatestDouble - lowestDouble;
            Assert.True(greatestDouble.IsGreaterOrEqualWithToleranceThan(lowestDouble, tolerance));
            Assert.True(lowestDouble.IsGreaterOrEqualWithToleranceThan(greatestDouble, tolerance));

            // with default tolerance
            Assert.True(greatestDouble.IsGreaterOrEqualWithToleranceThan(lowestDouble));
            Assert.True(lowestDouble.IsGreaterOrEqualWithToleranceThan(greatestDouble));
        }

        [Fact]
        public void Test_IsGreaterWithToleranceThan()
        {
            const double tolerance = greatestDouble - lowestDouble;
            Assert.True(greatestDouble.IsGreaterWithToleranceThan(lowestDouble, tolerance));
            Assert.False(lowestDouble.IsGreaterWithToleranceThan(greatestDouble, tolerance));

            // with default tolerance
            Assert.True(greatestDouble.IsGreaterOrEqualWithToleranceThan(lowestDouble));
            Assert.True(lowestDouble.IsGreaterOrEqualWithToleranceThan(greatestDouble));
        }

        [Fact]
        public void Test_IsLowerOrEqualWithToleranceThan()
        {
            Assert.True(lowestDouble.IsLowerOrEqualWithToleranceThan(greatestDouble, 0));
            Assert.False(greatestDouble.IsLowerOrEqualWithToleranceThan(lowestDouble, 0));

            const double tolerance = greatestDouble - lowestDouble;
            Assert.True(greatestDouble.IsLowerOrEqualWithToleranceThan(lowestDouble, tolerance));
            Assert.True(lowestDouble.IsLowerOrEqualWithToleranceThan(greatestDouble, tolerance));

            // with default tolerance
            Assert.True(greatestDouble.IsLowerOrEqualWithToleranceThan(lowestDouble));
            Assert.True(lowestDouble.IsLowerOrEqualWithToleranceThan(greatestDouble));
        }

        [Fact]
        public void Test_IsLowerWithToleranceThan()
        {
            const double tolerance = greatestDouble - lowestDouble;
            Assert.True(lowestDouble.IsLowerWithToleranceThan(greatestDouble, tolerance));
            Assert.False(greatestDouble.IsLowerWithToleranceThan(lowestDouble, tolerance));

            // with default tolerance
            Assert.True(greatestDouble.IsLowerOrEqualWithToleranceThan(lowestDouble));
            Assert.True(lowestDouble.IsLowerOrEqualWithToleranceThan(greatestDouble));
        }
    }
}
