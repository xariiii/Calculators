import java.util.List;
import javax.swing.*;
import java.awt.*;

public class Calculator {

    public static class CalcButton {
        String label;
        String value;

        public CalcButton(String label, String value) {
            this.label = label;
            this.value = value;
        }
    }

    static JTextField inputField;

    static double num1 = 0;
    static String operator = "";
    static boolean startNew = true;

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
            new CalcButton("x", "*"),
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
            new CalcButton(",", "."),
            new CalcButton("=", "=")
    );

    public static void main(String[] args) {

        JFrame frame = new JFrame("Calculator");
        frame.setSize(400, 600);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        inputField = new JTextField();
        inputField.setFont(new Font("Arial", Font.BOLD, 32));
        inputField.setHorizontalAlignment(SwingConstants.RIGHT);

        JPanel inputPanel = new JPanel(new BorderLayout());
        inputPanel.add(inputField, BorderLayout.CENTER);

        JPanel buttonsPanel = new JPanel(new GridLayout(6, 4, 5, 5));

        Color bg = new Color(30, 30, 30);
        Color panelBg = new Color(45, 45, 45);
        Color btnBg = new Color(60, 60, 60);
        Color btnFg = new Color(230, 230, 230);
        Color accent = new Color(0, 120, 215);

        frame.getContentPane().setBackground(bg);

        inputPanel.setBackground(panelBg);
        inputField.setBackground(new Color(20, 20, 20));
        inputField.setForeground(Color.WHITE);
        inputField.setCaretColor(Color.WHITE);
        inputField.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        buttonsPanel.setBackground(panelBg);

        for (CalcButton b : buttons) {
            JButton btn = new JButton(b.label);
            btn.setFont(new Font("Arial", Font.BOLD, 20));
            btn.setActionCommand(b.value);

            btn.setBackground(btnBg);
            btn.setForeground(btnFg);
            btn.setFocusPainted(false);
            btn.setBorder(BorderFactory.createLineBorder(new Color(80, 80, 80)));
            
            if ("+-*/".contains(b.value)) {
                btn.setBackground(accent);
                btn.setForeground(Color.WHITE);
            }

            btn.addActionListener(e -> handleButton(e.getActionCommand()));
            buttonsPanel.add(btn);
        }


        frame.setLayout(new BorderLayout());
        frame.add(inputPanel, BorderLayout.NORTH);
        frame.add(buttonsPanel, BorderLayout.CENTER);

        frame.setVisible(true);
    }

    static void handleButton(String val) {

        if (val.matches("[0-9]")) {
            if (startNew) {
                inputField.setText(val);
                startNew = false;
            } else {
                inputField.setText(inputField.getText() + val);
            }
            return;
        }

        if (val.equals(".")) {
            if (!inputField.getText().contains(".")) {
                inputField.setText(inputField.getText() + ".");
            }
            return;
        }

        if (val.equals("CE")) {
            inputField.setText("");
            return;
        }

        if (val.equals("C")) {
            inputField.setText("");
            num1 = 0;
            operator = "";
            startNew = true;
            return;
        }

        if (val.equals("DEL")) {
            String t = inputField.getText();
            if (!t.isEmpty()) {
                inputField.setText(t.substring(0, t.length() - 1));
            }
            return;
        }

        if (val.equals("+/-")) {
            if (!inputField.getText().isEmpty()) {
                double n = Double.parseDouble(inputField.getText());
                inputField.setText(String.valueOf(-n));
            }
            return;
        }

        if (val.equals("%")) {
            if (!inputField.getText().isEmpty()) {
                double n = Double.parseDouble(inputField.getText());
                inputField.setText(String.valueOf(n / 100));
            }
            return;
        }

        if (val.equals("1/x")) {
            double n = Double.parseDouble(inputField.getText());
            inputField.setText(String.valueOf(1 / n));
            return;
        }

        if (val.equals("x²")) {
            double n = Double.parseDouble(inputField.getText());
            inputField.setText(String.valueOf(n * n));
            return;
        }

        if (val.equals("√x")) {
            double n = Double.parseDouble(inputField.getText());
            inputField.setText(String.valueOf(Math.sqrt(n)));
            return;
        }

        if (val.matches("[+\\-*/]")) {
            num1 = Double.parseDouble(inputField.getText());
            operator = val;
            startNew = true;
            return;
        }

        if (val.equals("=")) {
            double num2 = Double.parseDouble(inputField.getText());
            double result = switch (operator) {
                case "+" -> num1 + num2;
                case "-" -> num1 - num2;
                case "*" -> num1 * num2;
                case "/" -> num1 / num2;
                default -> num2;
            };
            inputField.setText(String.valueOf(result));
            startNew = true;
        }
    }
}
