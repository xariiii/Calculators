import java.util.List;
import javax.swing.*;
import java.awt.*;

public class Calculator {

    // Static inner class so it can be used inside static main()
    public static class CalcButton {
        String label;
        String value;

        public CalcButton(String label, String value) {
            this.label = label;
            this.value = value;
        }
    }

    static JTextField inputField;

    // Static list so main() can access it
    static List<CalcButton> buttons = List.of(
            new CalcButton("%", "%"),
            new CalcButton("CE", "CE"),
            new CalcButton("C", "C"),
            new CalcButton("DEL", "DEL"),
            new CalcButton("1/x", "1/x"),
            new CalcButton("x²", "x²"),
            new CalcButton("√x", "√x"),
            new CalcButton("/", "/"),
            new CalcButton("7", "7"),
            new CalcButton("8", "8"),
            new CalcButton("9", "9"),
            new CalcButton("x", "x"),
            new CalcButton("4", "4"),
            new CalcButton("5", "5"),
            new CalcButton("6", "6"),
            new CalcButton("-", "-"),
            new CalcButton("1", "1"),
            new CalcButton("2", "2"),
            new CalcButton("3", "3"),
            new CalcButton("+", "+"),
            new CalcButton("+/-", "+/-"),
            new CalcButton("0", "0"),
            new CalcButton(",", ","),
            new CalcButton("=", "=")
    );

    public static void main(String[] args) {



        JFrame frame = new JFrame("Calculator");
        frame.setSize(400, 600);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        JPanel inputPanel = new JPanel();
        inputPanel.setLayout(new GridLayout(1,1));
        inputField = new JTextField(14);
        inputPanel.add(inputField);


        JPanel buttonsPanel = new JPanel();
        buttonsPanel.setLayout(new GridLayout(6, 4)); // 6 rows, 4 columns

        // Create buttons dynamically
        for (CalcButton b : buttons) {
            JButton btn = new JButton(b.label);
            btn.setActionCommand(b.value);

            btn.addActionListener(e -> {
                String val = e.getActionCommand();
                System.out.println("Pressed: " + val);
            });

            buttonsPanel.add(btn);
        }
        frame.add(inputPanel);
        frame.add(buttonsPanel);
        frame.setVisible(true);
    }
}
