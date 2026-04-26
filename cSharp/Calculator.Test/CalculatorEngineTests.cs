using Xunit;
using Calculator;

namespace Calculator.Test
{
    public class CalculatorEngineTests
    {
        [Fact]
        public void Add_ReturnsCorrectValue()
        {
            var calc = new CalculatorEngine();
            var result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectValue()
        {
            var calc = new CalculatorEngine();
            var result = calc.Subtract(10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectValue()
        {
            var calc = new CalculatorEngine();
            var result = calc.Multiply(6, 7);
            Assert.Equal(42, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectValue()
        {
            var calc = new CalculatorEngine();
            var result = calc.Divide(20, 5);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var calc = new CalculatorEngine();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
        }
    }
}
