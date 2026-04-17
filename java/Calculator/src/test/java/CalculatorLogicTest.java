import org.junit.Assert;
import org.junit.Test;

public class CalculatorLogicTest {

    private final CalculatorLogic logic = new CalculatorLogic();

    @Test
    public void testAddition() {
        Assert.assertEquals(5.0, logic.add(2, 3), 0.0001);
    }

    @Test
    public void testSubtraction() {
        Assert.assertEquals(1.0, logic.subtract(3, 2), 0.0001);
    }

    @Test
    public void testMultiplication() {
        Assert.assertEquals(6.0, logic.multiply(3, 2), 0.0001);
    }

    @Test
    public void testDivision() {
        Assert.assertEquals(2.0, logic.divide(6, 3), 0.0001);
    }

    @Test(expected = ArithmeticException.class)
    public void testDivideByZero() {
        logic.divide(5, 0);
    }

    @Test
    public void testPercent() {
        Assert.assertEquals(0.25, logic.percent(25), 0.0001);
    }

    @Test
    public void testInvert() {
        Assert.assertEquals(0.5, logic.invert(2), 0.0001);
    }

    @Test(expected = ArithmeticException.class)
    public void testInvertZero() {
        logic.invert(0);
    }

    @Test
    public void testSquare() {
        Assert.assertEquals(9.0, logic.square(3), 0.0001);
    }

    @Test
    public void testSqrt() {
        Assert.assertEquals(4.0, logic.sqrt(16), 0.0001);
    }

    @Test(expected = ArithmeticException.class)
    public void testSqrtNegative() {
        logic.sqrt(-4);
    }
}
