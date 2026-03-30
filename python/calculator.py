import tkinter as tk

# Setup
root = tk.Tk()
root.geometry("400x600")
root.title("Calculator")

# Colors
root.configure(bg="cadetblue2")

entryBox = tk.Entry(root)
entryBox.grid(row=0, column=0, columnspan=4, pady=10)

# Lists
colors = ["cadetblue", "cadetblue1", "cadetblue2", "cadetblue3", "cadetblue4"]
numbers = [
    "C", "CE", "%", "//",
    "(", ")", "^", "/",
    "7", "8", "9", "*",
    "4", "5", "6", "-",
    "1", "2", "3", "+",
    ".", "0", "=", "x"
]
nrow = 6
ncol = 4
index = 0 
for r in range(nrow):
    for c in range(ncol):
        num = numbers[index]
        button = tk.Button(root, text=num, width=10, height=5).grid(row=r+1, column=c)
        index += 1


root.mainloop()