import tkinter as tk
from tkinter import font
import math

# Setup
root = tk.Tk()
root.title("Calculator")
root.geometry("350x705")
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
# lists of symbols

orange_btn = ["CE", "C", "DEL", "="]
purple_btn = ["%", "1/x", "x²", "√x", "÷", "×", "-", "+", "+/-"]

# amount of rows and columns 

row_count = len(button_values)
column_count = len(button_values[0])

# layout

frame = tk.Frame(root)
HistoryLabel = tk.Label(frame, text="hist", font=custom_font_history, background=white_color, foreground=purple_color, anchor="e", width=column_count)
ResultBox2 = tk.Label(frame, text="1", font=custom_font_history, background=white_color, foreground=purple_color, anchor="e", width=column_count)
ResultBox = tk.Label(frame, text="0", font=custom_font, background=white_color, foreground=purple_color, anchor="e", width=column_count)

HistoryLabel.grid(row=0, column=0, columnspan=column_count, sticky="we", pady=3)
ResultBox2.grid(row=1, column=0, columnspan=column_count, sticky="we")
ResultBox.grid(row=2, column=0, columnspan=column_count, sticky="we")

for row in range(row_count):
    for column in range(column_count):
        value = button_values[row][column]
        button = tk.Button(frame, text=value, font=custom_font,
                           width=column_count-1, height=1, 
                           command=lambda value=value: button_clicked(value))
        
        if value in orange_btn:
            button.config(foreground=white_color, background=orange_color, width=2, height=2)
        elif value in purple_btn:
            button.config(foreground=white_color, background=purple_color, width=2, height=2)
        else:
            button.config(foreground=purple_color, background=white_color, width=2, height=2)
        button.grid(row=row+3, column=column, padx=3, pady=3)

frame.pack()

# functions

def remove_zero_decimal(num):
    if num % 1 == 0:
        num = int(num)
    return str(num)

def button_clicked(value):
    global ResultBox

    text = ResultBox["text"]
    if text == "Error":
        if value not in ["C", "CE"]:
            ResultBox["text"] = "0"
            text = "0"

    if value == "=":
        expr = text.replace("×", "*").replace("÷", "/")
        try:
            result = eval(expr)
            ResultBox["text"] = remove_zero_decimal(result)
        except:
            ResultBox["text"] = "Error"
        return

    if value == "C":
        ResultBox["text"] = "0"
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
            if num == "0":
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
    
    if value == "CE":
        ResultBox["text"] == "0"
        return
    
    if value == "DEL":
        if len(text) > 1:
            ResultBox["text"] = text[:-1]
        else: 
            ResultBox["text"] = "0"
        return


    if text == "0":
        ResultBox["text"] = value
    else:
        ResultBox["text"] += value

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
