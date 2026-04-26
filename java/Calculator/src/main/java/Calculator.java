import java.awt.*;
import java.awt.event.ActionEvent;
import java.util.List;
import javax.swing.*;

public class Calculator {

    static JTextField inputField;
    static JTextArea historyArea;

    static boolean ttsEnabled = false;
    static boolean partyMode = false;
    static boolean historyVisible = false;

    static double lastValue = 0;
    static String lastOperator = "";
    static boolean resetOnNext = false;

    static Timer partyTimer;
    static float hue = 0f;

    static class CalcButton {
        String label, value;
        CalcButton(String l, String v) { label = l; value = v; }
    }

    static List<CalcButton> buttons = List.of(
            new CalcButton("%", "%"), new CalcButton("CE", "CE"),
            new CalcButton("C", "C"), new CalcButton("DEL", "DEL"),
            new CalcButton("1/x", "1/x"), new CalcButton("x²", "x^2"),
            new CalcButton("√x", "sqrt"), new CalcButton("/", "/"),
            new CalcButton("7", "7"), new CalcButton("8", "8"),
            new CalcButton("9", "9"), new CalcButton("*", "*"),
            new CalcButton("4", "4"), new CalcButton("5", "5"),
            new CalcButton("6", "6"), new CalcButton("-", "-"),
            new CalcButton("1", "1"), new CalcButton("2", "2"),
            new CalcButton("3", "3"), new CalcButton("+", "+"),
            new CalcButton("+/-", "+/-"), new CalcButton("0", "0"),
            new CalcButton(".", "."), new CalcButton("=", "=")
    );

    public static void main(String[] args) {

        JFrame frame = new JFrame("Calculator");
        frame.setSize(360, 720);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLayout(null);

        Color purple = new Color(82, 82, 152);
        Color white = new Color(242, 242, 247);
        Color orange = new Color(245, 149, 95);

        frame.getContentPane().setBackground(Color.WHITE);

        inputField = new JTextField();
        inputField.setBounds(10, 50, 330, 70);
        inputField.setFont(new Font("Segoe UI", Font.BOLD, 32));
        inputField.setHorizontalAlignment(SwingConstants.RIGHT);
        inputField.setBackground(white);
        inputField.setForeground(purple);
        inputField.setBorder(BorderFactory.createEmptyBorder(10,10,10,10));
        inputField.setEditable(false);
        frame.add(inputField);

        JButton ttsBtn = new JButton("🔊");
        JButton partyBtn = new JButton("🎉");
        JButton historyBtn = new JButton("H");

        ttsBtn.setBounds(10, 10, 60, 30);
        partyBtn.setBounds(80, 10, 60, 30);
        historyBtn.setBounds(280, 10, 60, 30);

        ttsBtn.setBackground(Color.GRAY);
        ttsBtn.setForeground(Color.WHITE);

        partyBtn.setBackground(Color.GRAY);
        partyBtn.setForeground(Color.WHITE);

        historyBtn.setBackground(orange);
        historyBtn.setForeground(Color.WHITE);

        frame.add(ttsBtn);
        frame.add(partyBtn);
        frame.add(historyBtn);

        historyArea = new JTextArea();
        historyArea.setEditable(false);
        JScrollPane scroll = new JScrollPane(historyArea);
        scroll.setBounds(10, 550, 330, 120);
        scroll.setVisible(false);
        frame.add(scroll);

        historyBtn.addActionListener(e -> {
            historyVisible = !historyVisible;
            scroll.setVisible(historyVisible);
            speakToggle("historia", historyVisible);
        });

        partyBtn.addActionListener(e -> {
            partyMode = !partyMode;
            partyBtn.setBackground(partyMode ? orange : Color.GRAY);
            speakToggle("tryb imprezowy", partyMode);
            togglePartyMode(frame);
        });

        ttsBtn.addActionListener(e -> {
            ttsEnabled = !ttsEnabled;
            ttsBtn.setBackground(ttsEnabled ? purple : Color.GRAY);
            speakToggle("tryb mówienia", ttsEnabled);
        });

        int size = 75;
        int gap = 8;

        int x0 = 10;
        int y0 = 140;

        int x = x0, y = y0, col = 0;

        for (CalcButton b : buttons) {

            JButton btn = new JButton(b.label);
            btn.setBounds(x, y, size, size);
            btn.setFont(new Font("Segoe UI", Font.BOLD, 20));
            btn.setFocusPainted(false);
            btn.setOpaque(true);

            btn.setActionCommand(b.value);

            if (b.value.matches("[0-9]") || b.value.equals(".")) {
                btn.setBackground(white);
                btn.setForeground(purple);
            } else if (List.of("C","CE","DEL","=").contains(b.value)) {
                btn.setBackground(orange);
                btn.setForeground(Color.WHITE);
            } else {
                btn.setBackground(purple);
                btn.setForeground(Color.WHITE);
            }

            btn.addActionListener(Calculator::handle);

            frame.add(btn);

            col++;
            x += size + gap;

            if (col == 4) {
                col = 0;
                x = x0;
                y += size + gap;
            }
        }

        frame.setVisible(true);
    }

    static void togglePartyMode(JFrame frame) {
        if (partyMode) {
            partyTimer = new Timer(30, e -> {
                hue += 0.01f;
                if (hue > 1) hue = 0;
                frame.getContentPane().setBackground(Color.getHSBColor(hue, 0.4f, 1f));
            });
            partyTimer.start();
        } else {
            if (partyTimer != null) partyTimer.stop();
            frame.getContentPane().setBackground(Color.WHITE);
        }
    }

    static void speak(String text) {
        if (!ttsEnabled) return;

        String mapped = switch (text) {
            case "+" -> "plus";
            case "-" -> "minus";
            case "*" -> "razy";
            case "/" -> "podzielone przez";
            case "%" -> "procent";
            case "." -> "przecinek";
            case "," -> "przecinek";
            case "C" -> "czyść";
            case "CE" -> "czyść ostatnie";
            case "DEL" -> "usuń";
            default -> text;
        };

        if (text.matches("[0-9.,]+")) {
            mapped = text.replace(",", ".")
                    .chars()
                    .mapToObj(c -> c == '.' ? "przecinek" : String.valueOf((char) c))
                    .reduce("", (a, b) -> a + " " + b)
                    .trim();
        }

        try {
            new ProcessBuilder(
                    "powershell",
                    "-Command",
                    "Add-Type -AssemblyName System.Speech;" +
                            "$s = New-Object System.Speech.Synthesis.SpeechSynthesizer;" +
                            "$s.Speak('" + mapped.replace("'", "''") + "');"
            ).start();
        } catch (Exception ignored) {}
    }

    static void speakResult(String prefix, String result) {
        if (!ttsEnabled) return;

        String digits = result.replace(",", ".")
                .chars()
                .mapToObj(c -> c == '.' ? "przecinek" : String.valueOf((char) c))
                .reduce("", (a, b) -> a + " " + b)
                .trim();

        String text = (prefix + " wynik " + digits).trim();

        try {
            new ProcessBuilder(
                    "powershell",
                    "-Command",
                    "Add-Type -AssemblyName System.Speech;" +
                            "$s = New-Object System.Speech.Synthesis.SpeechSynthesizer;" +
                            "$s.Speak('" + text.replace("'", "''") + "');"
            ).start();
        } catch (Exception ignored) {}
    }

    static void speakToggle(String feature, boolean state) {
        if (!ttsEnabled) return;

        String text = feature + " " + (state ? "włączony" : "wyłączony");

        try {
            new ProcessBuilder(
                    "powershell",
                    "-Command",
                    "Add-Type -AssemblyName System.Speech;" +
                            "$s = New-Object System.Speech.Synthesis.SpeechSynthesizer;" +
                            "$s.Speak('" + text.replace("'", "''") + "');"
            ).start();
        } catch (Exception ignored) {}
    }

    static void handle(ActionEvent e) {
        String v = e.getActionCommand();
        String t = inputField.getText();

        if (!List.of("sqrt", "x^2", "1/x", "=").contains(v)) {
            speak(v);
        }

        switch (v) {

            case "C" -> {
                inputField.setText("");
                lastOperator = "";
                lastValue = 0;
                resetOnNext = false;
            }

            case "CE" -> inputField.setText("");

            case "DEL" -> {
                if (!t.isEmpty())
                    inputField.setText(t.substring(0, t.length() - 1));
            }

            case "+/-" -> {
                if (!t.isEmpty()) {
                    boolean wasNegative = t.startsWith("-");
                    String newValue = wasNegative ? t.substring(1) : "-" + t;

                    String spoken = wasNegative
                            ? "zmiana znaku, " + newValue
                            : "zmiana znaku, minus " + t;

                    speak(spoken);
                    inputField.setText(newValue);
                }
            }


            case "%" -> {
                if (!t.isEmpty()) {
                    try {
                        double num = Double.parseDouble(t);
                        double res = num / 100;
                        String out = clean(res);
                        inputField.setText(out);
                        historyArea.append(t + "% = " + out + "\n");
                        speakResult("procent z " + t + " to", out);
                        resetOnNext = true;
                    } catch (Exception ex) {
                        speak("wystąpił błąd");
                        inputField.setText("Error");
                    }
                }
            }

            case "1/x" -> {
                if (!t.isEmpty()) {
                    try {
                        double n = Double.parseDouble(t);
                        double res = 1 / n;
                        String out = clean(res);
                        inputField.setText(out);
                        speakResult("odwrotność " + t + " to", out);
                        resetOnNext = true;
                    } catch (Exception ex) {
                        speak("wystąpił błąd");
                        inputField.setText("Error");
                    }
                }
            }

            case "x^2" -> {
                if (!t.isEmpty()) {
                    try {
                        double n = Double.parseDouble(t);
                        double res = n * n;
                        String out = clean(res);
                        inputField.setText(out);
                        speakResult(t + " do kwadratu to", out);
                        resetOnNext = true;
                    } catch (Exception ex) {
                        speak("wystąpił błąd");
                        inputField.setText("Error");
                    }
                }
            }

            case "sqrt" -> {
                if (!t.isEmpty()) {
                    try {
                        double n = Double.parseDouble(t);
                        double res = Math.sqrt(n);
                        String out = clean(res);
                        inputField.setText(out);
                        speakResult("pierwiastek z " + t + " to", out);
                        resetOnNext = true;
                    } catch (Exception ex) {
                        speak("wystąpił błąd");
                        inputField.setText("Error");
                    }
                }
            }

            case "+", "-", "*", "/" -> {
                if (!t.isEmpty()) {
                    lastValue = Double.parseDouble(t);
                    lastOperator = v;
                    inputField.setText(t + v);
                    resetOnNext = false;
                }
            }

            case "=" -> {
                if (!t.isEmpty() && !lastOperator.isEmpty() && t.contains(lastOperator)) {

                    try {
                        int idx = t.lastIndexOf(lastOperator);
                        String left = t.substring(0, idx);
                        String right = t.substring(idx + 1);

                        double n1 = Double.parseDouble(left);
                        double n2 = Double.parseDouble(right);

                        double result = switch (lastOperator) {
                            case "+" -> n1 + n2;
                            case "-" -> n1 - n2;
                            case "*" -> n1 * n2;
                            case "/" -> n1 / n2;
                            default -> n2;
                        };

                        String out = clean(result);
                        historyArea.append(left + " " + lastOperator + " " + right + " = " + out + "\n");

                        inputField.setText(out);
                        speakResult("", out);

                        resetOnNext = true;
                        lastValue = result;

                    } catch (Exception ex) {
                        speak("wystąpił błąd");
                        inputField.setText("Error");
                    }
                }
            }

            default -> {
                if (resetOnNext) {
                    inputField.setText(v);
                    resetOnNext = false;
                } else {
                    inputField.setText(t + v);
                }
            }
        }
    }

    static String clean(double v) {
        if (v == (long) v) return String.valueOf((long) v);
        return String.valueOf(v);
    }
}
