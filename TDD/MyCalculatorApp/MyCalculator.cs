namespace MyCalculatorApp
{
    public class MyCalculator
    {
        public double Divide(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new CannotDivideToZeroException();
            }

            return number1 / number2;
        }

        public int Plus(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}