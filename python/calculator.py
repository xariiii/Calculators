import tkinter as tk
import math

# Setup
root = tk.Tk()
root.title("Calculator")
root.resizable(False, False)
root.iconbitmap("python/calculator.ico")


# button values

button_values = [
    ["%", "CE", "C", "<x"],
    ["1/x", "²", "√", "÷"],
    ["7", "8", "9", "×"],
    ["4", "5", "6", "-"],
    ["1", "2", "3", "+"],
    ["+/-", "0", ".","="]
]

# color pallete

label_color = "#394158"
button_color = "#273469"
text_color = "#fafaff"
top_color = "#7A65B0"
right_color = "#1e2749"

# lists of symbols

right_symbols = ["÷", "×", "-", "+", "="]
top_symbols = ["%", "CE", "C", "<x"]

# amount of rows and columns 

row_count = len(button_values)
column_count = len(button_values[0])

# layout

frame = tk.Frame(root)
label = tk.Label(frame, text="0", font=("Arial", 45), background=label_color, foreground=text_color, anchor="e", width=column_count)

label.grid(row=0, column=0, columnspan=column_count, sticky="we")

for row in range(row_count):
    for column in range(column_count):
        value = button_values[row][column]
        button = tk.Button(frame, text=value, font=("Arial", 30),
                           width=column_count-1, height=1, 
                           command=lambda value=value: button_clicked(value))
        
        if value in top_symbols:
            button.config(foreground=text_color, background=top_color)
        elif value in right_symbols:
            button.config(foreground=text_color, background=right_color)
        else:
            button.config(foreground=text_color, background=button_color)
        button.grid(row=row+1, column=column)

frame.pack()

# functions

def remove_zero_decimal(num):
    if num % 1 == 0:
        num = int(num)
    return str(num)

def button_clicked(value):
    global label

    text = label["text"]
    if text == "Error":
        if value not in ["C", "CE"]:
            label["text"] = "0"
            text = "0"

    if value == "=":
        expr = text.replace("×", "*").replace("÷", "/")
        try:
            result = eval(expr)
            label["text"] = remove_zero_decimal(result)
        except:
            label["text"] = "Error"
        return

    if value == "C":
        label["text"] = "0"
        return

    if value == "+/-":
        try:
            num = float(text)
            label["text"] = remove_zero_decimal(-num)
        except:
            pass
        return

    if value == "%":
        try:
            num = float(text)
            label["text"] = remove_zero_decimal(num / 100)
        except:
            pass
        return

    if value == "√":
        try:
            num = float(text)
            label["text"] = remove_zero_decimal(math.sqrt(num))
        except:
            label["text"] = "Error"
        return
    
    if value == "1/x":
        try:
            num = float(text)
            if num == "0":
                label["text"] = "Error"
            else:
                label["text"] = remove_zero_decimal(1 / num)
        except:
            label["text"] = "Error"
        return
    
    if value == "²":
        try:
            num = float(text)
            label["text"] = remove_zero_decimal(num * num)
        except:
            label["text"] = "Error"
        return
    
    if value == "CE":
        label["text"] == "0"
        return
    
    if value == "<x":
        if len(text) > 1:
            label["text"] = text[:-1]
        else: 
            label["text"] = "0"
        return


    if text == "0":
        label["text"] = value
    else:
        label["text"] += value

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
