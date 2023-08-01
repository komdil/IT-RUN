using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using MyCalculatorApp;

namespace Calculator.UnitTests
{
    public class CalculatorTests
    {
        [TestCase(10, 10, 20)]
        [TestCase(-10, 10, 0)]
        [TestCase(-10, -10, -20)]
        public void Calculator_Plus_Test(int number1, int number2, int expectedResult)
        {
            MyCalculator calculator = new MyCalculator();
            int result = calculator.Plus(number1, number2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(20D, 10D, 2)]
        [TestCase(-10D, 10D, -1)]
        [TestCase(-10D, -10D, 1D)]
        public void Calculator_Divide_Test(double number1, double number2, double expectedResult)
        {
            MyCalculator calculator = new MyCalculator();
            double result = calculator.Divide(number1, number2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Calculator_DivideOnZero_ShouldThrowException_Test()
        {
            MyCalculator calculator = new MyCalculator();
            Assert.Throws<CannotDivideToZeroException>(() =>
            {
                calculator.Divide(100, 0);
            });
        }
    }
}
