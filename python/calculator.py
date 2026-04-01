import tkinter as tk

# Setup
root = tk.Tk()
root.geometry("400x600")
root.title("Calculator")

# Colors
root.configure(bg="cadetblue2")

# Lists
colors = ["cadetblue", "cadetblue1", "cadetblue2", "cadetblue3", "cadetblue4"]
numbers = [
    "1", "2", "3", "4", "5"," 6", "7", "8", "9", "0",
    "C", "CE", "%", "//",
    "(", ")", "^", "/",
    "*", "-", "+",".", 
    "=", "x"
]

values = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
digit_map = {str(v): str(v) for v in values}

for label in numbers:
    if label not in digit_map:
        digit_map[label] = label

def on_button_click(label):
    value = digit_map[label]
    entry.insert(tk.END, value)

entry = tk.Entry(root)
entry.grid(row=0, column=0, columnspan=4, pady=10)

max_col = 4

for i, label in enumerate(numbers):
    row = i // max_col
    col = i % max_col
    button = tk.Button(root, text=label, width=10, height=5, command=lambda l=label: on_button_click(l))
    button.grid(row=row + 1, column=col )


root.mainloop()