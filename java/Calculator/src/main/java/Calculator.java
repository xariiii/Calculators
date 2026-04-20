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
    static JTextArea historyArea;

    static double num1 = 0;
    static String operator = "";
    static boolean startNew = true;

    static List<CalcButton> buttons = List.of(
            new CalcButton("%", "%"), new CalcButton("CE", "CE"),
            new CalcButton("C", "C"), new CalcButton("DEL", "DEL"),
            new CalcButton("1/x", "1/x"), new CalcButton("x²", "x²"),
            new CalcButton("√x", "√x"), new CalcButton("/", "/"),
            new CalcButton("7", "7"), new CalcButton("8", "8"),
            new CalcButton("9", "9"), new CalcButton("x", "*"),
            new CalcButton("4", "4"), new CalcButton("5", "5"),
            new CalcButton("6", "6"), new CalcButton("-", "-"),
            new CalcButton("1", "1"), new CalcButton("2", "2"),
            new CalcButton("3", "3"), new CalcButton("+", "+"),
            new CalcButton("+/-", "+/-"), new CalcButton("0", "0"),
            new CalcButton(",", "."), new CalcButton("=", "=")
    );

    public static void main(String[] args) {

        JFrame frame = new JFrame("Calculator");
        frame.setSize(350, 705);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLayout(null);

        Color purple = new Color(82, 82, 152);
        Color white = new Color(242, 242, 247);
        Color orange = new Color(245, 149, 95);

        // === INPUT ===
        inputField = new JTextField();
        inputField.setFont(new Font("Segoe UI", Font.BOLD, 25));
        inputField.setHorizontalAlignment(SwingConstants.RIGHT);
        inputField.setBounds(10, 40, 330, 60);
        inputField.setBackground(Color.WHITE);
        inputField.setForeground(purple);
        inputField.setEditable(false);

        JButton historyButton = new JButton("H");
        historyButton.setFont(new Font("Segoe UI", Font.BOLD, 20));
        historyButton.setBounds(290, 5, 50, 30);
        historyButton.setBackground(orange);
        historyButton.setForeground(white);

        frame.add(inputField);
        frame.add(historyButton);

        // pokaż okno żeby znać realny rozmiar
        frame.setVisible(true);

        // === REALNY ROZMIAR (KLUCZ!) ===
        int contentW = frame.getContentPane().getWidth();
        int contentH = frame.getContentPane().getHeight();

        int btnSize = 75;

        // === HORIZONTAL (fix uciania z prawej) ===
        int gapX = 8;
        int totalW = 4 * btnSize + 3 * gapX;
        int startX = (contentW - totalW) / 2;

        // === VERTICAL (fix braku miejsca na dole) ===
        int topOffset = 130;
        int rows = 6;

        int availableH = contentH - topOffset - 10;
        int gapY = (availableH - rows * btnSize) / (rows - 1);

        if (gapY < 2) gapY = 2; // zabezpieczenie

        int x = startX;
        int y = topOffset;
        int col = 0;

        for (CalcButton b : buttons) {

            JButton btn = new JButton(b.label);
            btn.setFont(new Font("Segoe UI", Font.BOLD, 20));
            btn.setBounds(x, y, btnSize, btnSize);
            btn.setFocusPainted(false);
            btn.setActionCommand(b.value);

            if (b.value.matches("[0-9]") || b.value.equals(".")) {
                btn.setBackground(white);
                btn.setForeground(purple);
            } else if (b.value.equals("CE") || b.value.equals("C") || b.value.equals("DEL")) {
                btn.setBackground(orange);
                btn.setForeground(white);
            } else if (b.value.equals("=")) {
                btn.setBackground(orange);
                btn.setForeground(white);
            } else {
                btn.setBackground(purple);
                btn.setForeground(white);
            }

            btn.addActionListener(e -> handleButton(e.getActionCommand()));
            frame.add(btn);

            col++;
            x += btnSize + gapX;

            if (col == 4) {
                col = 0;
                x = startX;
                y += btnSize + gapY;
            }
        }

        // === HISTORY ===
        historyArea = new JTextArea();
        historyArea.setFont(new Font("Segoe UI", Font.BOLD, 16));

        JScrollPane scroll = new JScrollPane(historyArea);
        scroll.setBounds(10, contentH - 260, contentW - 20, 250);
        scroll.setVisible(false);

        frame.add(scroll);

        historyButton.addActionListener(e ->
                scroll.setVisible(!scroll.isVisible())
        );

        frame.repaint();
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

            historyArea.append(num1 + " " + operator + " " + num2 + " = " + result + "\n");
            inputField.setText(String.valueOf(result));
            startNew = true;
        }
    }
}