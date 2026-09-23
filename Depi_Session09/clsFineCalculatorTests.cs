using Xunit;

namespace Depi_Session09
{
    public class FineCalculatorTests
    {
        // A new instance of this class is created for every test, so the calculator is created in the constructor
        private readonly FineCalculator _calculator;

        public FineCalculatorTests()
        {
            _calculator = new FineCalculator();
        }

        // 1) Add - Assert.Equal
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(5, result);
        }

        // 2) Add - Assert.NotEqual
        [Fact]
        public void Add_ShouldReturnNotEqual()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.NotEqual(6, result);
        }

        // 3) Subtract - Assert.Equal
        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(6, result);
        }

        // 4) Multiply - Theory with 3 InlineData (includes a negative case)
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(0, 7, 0)]
        [InlineData(-4, 5, -20)]
        public void Multiply_ShouldReturnCorrectResult(int a, int b, int expected)
        {
            // Arrange (the data comes from InlineData)

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        // 5) Multiply - Theory with 3 InlineData, Assert.NotEqual
        [Theory]
        [InlineData(2, 3, 7)]
        [InlineData(4, 5, 25)]
        [InlineData(-2, 3, 6)]
        public void Multiply_ShouldReturnNotEqual(int a, int b, int notExpected)
        {
            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.NotEqual(notExpected, result);
        }

        // 6) Divide by zero - Assert.Throws
        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act + Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }
    }
}
