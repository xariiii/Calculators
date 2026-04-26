namespace Calculator
{
    public class CalculatorEngine
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

        public double Square(double a) => a * a;
        public double SquareRoot(double a) => Math.Sqrt(a);
        public double Percent(double a) => a / 100;
        public double Invert(double a) => 1 / a;
        public double Negate(double a) => -a;
    }
}
