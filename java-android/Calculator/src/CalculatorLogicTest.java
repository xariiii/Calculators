import org.junit.Assert;
import org.junit.Test;

public class CalculatorLogicTest {

    @Test
    public void testAddition() {
        CalculatorLogic calc = new CalculatorLogic();
        Assert.assertEquals(5, calc.add(2, 3), 0.0001);
    }

    @Test
    public void testDivision() {
        CalculatorLogic calc = new CalculatorLogic();
        Assert.assertEquals(2, calc.divide(10, 5), 0.0001);
    }
}
