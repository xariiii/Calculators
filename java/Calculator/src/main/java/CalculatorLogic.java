public class CalculatorLogic {

    public double add(double a, double b) {
        return a + b;
    }

    public double subtract(double a, double b) {
        return a - b;
    }

    public double multiply(double a, double b) {
        return a * b;
    }

    public double divide(double a, double b) {
        if (b == 0) {
            throw new ArithmeticException("Cannot divide by zero");
        }
        return a / b;
    }

    public double percent(double a) {
        return a / 100.0;
    }

    public double invert(double a) {
        if (a == 0) {
            throw new ArithmeticException("Cannot invert zero");
        }
        return 1.0 / a;
    }

    public double square(double a) {
        return a * a;
    }

    public double sqrt(double a) {
        if (a < 0) {
            throw new ArithmeticException("Cannot take square root of negative number");
        }
        return Math.sqrt(a);
    }
}
