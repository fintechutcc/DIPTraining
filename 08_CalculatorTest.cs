using CSharpTraining;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd2and2()
        {
            double a = 2;
            double b = 2;
            double expected = 4;

            Calculator calc = new();
            double actual = calc.Add(a, b);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAdd3and2()
        {
            double a = 3;
            double b = 2;
            double expected = 5;

            Calculator calc = new();
            double actual = calc.Add(a, b);
            Assert.Equal(expected, actual);
        }
    }
}