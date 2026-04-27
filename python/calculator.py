import tkinter as tk
from tkinter import font
import math

# Setup
root = tk.Tk()
root.title("Calculator")
root.geometry("350x800")
root.iconbitmap("python/calculator.ico")


# button values

button_values = [
    ["%", "CE", "C", "DEL"],
    ["1/x", "x²", "√x", "÷"],
    ["7", "8", "9", "×"],
    ["4", "5", "6", "-"],
    ["1", "2", "3", "+"],
    ["+/-", "0", ".","="]
]

# color pallete

white_color = "#f2f2f7"
purple_color = "#525298"
orange_color = "#f5955f"

# font

custom_font = font.Font(family="Segoe UI", size=20, weight="bold")
custom_font_history = font.Font(family="Segoe UI", size=16, weight="bold")

# lists 

orange_btn = ["CE", "C", "DEL", "="]
purple_btn = ["%", "1/x", "x²", "√x", "÷", "×", "-", "+", "+/-"]
history = []

# amount of rows and columns 

row_count = len(button_values)
column_count = len(button_values[0])

# layout

frame = tk.Frame(root)

top_row = tk.Frame(frame, background=white_color)
top_row.grid(row=0, column=0, columnspan=column_count, sticky="we", pady=3)

HistoryLabel = tk.Label(top_row, background=white_color, foreground=purple_color,
                        anchor="w")

HistoryButton = tk.Button(top_row, text="⟲", font=custom_font_history,
                          background=white_color, foreground=purple_color,
                          command=lambda: open_history())

HistoryLabel.pack(side="left", fill="x", expand=True)
HistoryButton.pack(side="right")


ResultBox2 = tk.Label(frame, font=custom_font_history,
                      background=white_color, foreground=purple_color,
                      anchor="e", padx=5)

ResultBox = tk.Label(frame, text="0", font=custom_font,
                     background=white_color, foreground=purple_color,
                     anchor="e", padx=5)

ResultBox2.grid(row=1, column=0, columnspan=column_count, sticky="we")
ResultBox.grid(row=2, column=0, columnspan=column_count, sticky="we")

for i in range(column_count):
    frame.grid_columnconfigure(i, weight=1)

for row in range(row_count):
    for column in range(column_count):
        value = button_values[row][column]

        button = tk.Button(frame, text=value, font=custom_font,
                           height=2,
                           command=lambda value=value: button_clicked(value))

        if value in orange_btn:
            button.config(foreground=white_color, background=orange_color)
        elif value in purple_btn:
            button.config(foreground=white_color, background=purple_color)
        else:
            button.config(foreground=purple_color, background=white_color)

        button.grid(row=row + 3, column=column, padx=3, pady=3, sticky="nsew")

frame.pack(fill="both", expand=True)




# functions
def open_history():
    history_window = tk.Toplevel(root)
    history_window.title("History")

    # Size of the history window
    w = 300
    h = 400

    # Get main window position and size
    root.update_idletasks()
    rx = root.winfo_x()
    ry = root.winfo_y()
    rw = root.winfo_width()
    rh = root.winfo_height()

    # Center horizontally, bottom aligned
    x = rx + (rw // 2) - (w // 2)
    y = ry + rh - h

    history_window.geometry(f"{w}x{h}+{x}+{y}")

    if len(history) == 0:
        label = tk.Label(history_window, text="You don't have any history yet.",
                         font=custom_font_history, foreground=purple_color, anchor="w")
        label.pack(padx=5, pady=5)
        return

    for entry in history:
        label = tk.Label(history_window, text=entry,
                         font=custom_font_history, foreground=purple_color, anchor="w")
        label.pack(padx=10, pady=5)


def remove_zero_decimal(num):
    if num % 1 == 0:
        num = int(num)
    return str(num)

first_value = None
current_operator = None
last_was_equals = False


def button_clicked(value):
    global ResultBox, ResultBox2, first_value, current_operator, last_was_equals

    text = ResultBox["text"]

    if text == "Error":
        if value not in ["C", "CE"]:
            ResultBox["text"] = "0"
            text = "0"

    if value.isdigit() or value == ".":
        if text == "0" or last_was_equals:
            ResultBox["text"] = value
        else:
            ResultBox["text"] += value
        last_was_equals = False
        return

    if value in ["+", "-", "×", "÷"]:
        try:
            first_value = float(ResultBox["text"])
        except:
            first_value = 0
        current_operator = value
        ResultBox2["text"] = f"{remove_zero_decimal(first_value)} {value}"
        ResultBox["text"] = "0"
        last_was_equals = False
        return

    if value == "=":
        if current_operator is not None and first_value is not None:
            try:
                second_value = float(ResultBox["text"])
                a = first_value
                b = second_value

                if current_operator == "+":
                    result = a + b
                elif current_operator == "-":
                    result = a - b
                elif current_operator == "×":
                    result = a * b
                elif current_operator == "÷":
                    if b == 0:
                        ResultBox["text"] = "Error"
                        return
                    result = a / b

                result_str = remove_zero_decimal(result)
                expr_str = f"{remove_zero_decimal(a)} {current_operator} {remove_zero_decimal(b)}"

                ResultBox["text"] = result_str
                ResultBox2["text"] = expr_str + " ="

                history.append(f"{expr_str} = {result_str}")

                first_value = None
                current_operator = None
                last_was_equals = True

            except:
                ResultBox["text"] = "Error"
        return

    if value == "C":
        ResultBox["text"] = "0"
        ResultBox2["text"] = ""
        first_value = None
        current_operator = None
        last_was_equals = False
        return

    if value == "CE":
        ResultBox["text"] = "0"
        last_was_equals = False
        return

    if value == "DEL":
        if len(text) > 1:
            ResultBox["text"] = text[:-1]
        else:
            ResultBox["text"] = "0"
        last_was_equals = False
        return

    if value == "+/-":
        try:
            num = float(text)
            ResultBox["text"] = remove_zero_decimal(-num)
        except:
            pass
        return

    if value == "%":
        try:
            num = float(text)
            ResultBox["text"] = remove_zero_decimal(num / 100)
        except:
            pass
        return

    if value == "√x":
        try:
            num = float(text)
            ResultBox["text"] = remove_zero_decimal(math.sqrt(num))
        except:
            ResultBox["text"] = "Error"
        return

    if value == "1/x":
        try:
            num = float(text)
            if num == 0:
                ResultBox["text"] = "Error"
            else:
                ResultBox["text"] = remove_zero_decimal(1 / num)
        except:
            ResultBox["text"] = "Error"
        return

    if value == "x²":
        try:
            num = float(text)
            ResultBox["text"] = remove_zero_decimal(num * num)
        except:
            ResultBox["text"] = "Error"
        return



# centering the window on a screen

root.update()
root_width = root.winfo_width()
root_height = root.winfo_height()
screen_width = root.winfo_screenwidth()
screen_height = root.winfo_screenheight()

window_x = int((screen_width/2) - (root_width/2))
window_y = int((screen_height/2) - (root_height/2))

root.geometry(f"{root_width}x{root_height}+{window_x}+{window_y}")

root.mainloop()
