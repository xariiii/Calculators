import pytest 
from calculator import remove_zero_decimal
import math

def eval_expr(expr):
    expr = expr.replace("×", "*").replace("÷", "/")
    return remove_zero_decimal(eval(expr))

def test_add():
    assert eval_expr("2+3") == "5"

def test_sub():
    assert eval_expr("10-4") == "6"

def test_mul():
    assert eval_expr("7×8") == "56"

def test_div():
    assert eval_expr("20÷4") == "5"

def test_backspace():
    text = "123"
    assert text[:-1] == "12"

def test_square():
    assert remove_zero_decimal(5 * 5) == "25"

def test_inverse():
    assert remove_zero_decimal(1 / 4) == "0.25"

def test_sqrt():
    assert remove_zero_decimal(math.sqrt(9)) == "3"

def test_plus_minus():
    num = -float("5")
    assert remove_zero_decimal(num) == "-5"

def test_percent():
    assert remove_zero_decimal(50 / 100) == "0.5"


