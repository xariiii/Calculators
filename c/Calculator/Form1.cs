using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = string.Empty;
        bool enterValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0" || enterValue)
                ResultBox.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!ResultBox.Text.Contains("."))
                    ResultBox.Text += ".";
            }
            else
            {
                ResultBox.Text += button.Text;
            }
        }

        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0)
                BtnEquals.PerformClick();
            else
                result = double.Parse(ResultBox.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;

            ResultBox.Text = string.Empty;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == string.Empty)
                return;

            double secondValue = double.Parse(ResultBox.Text);

            switch (operation)
            {
                case "+":
                    ResultBox.Text = (result + secondValue).ToString();
                    break;
                case "-":
                    ResultBox.Text = (result - secondValue).ToString();
                    break;
                case "×":
                    ResultBox.Text = (result * secondValue).ToString();
                    break;
                case "÷":
                    if (secondValue == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    ResultBox.Text = (result / secondValue).ToString();
                    break;
            }

            result = double.Parse(ResultBox.Text);
            operation = string.Empty;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            result = 0;
            operation = string.Empty;
            enterValue = false;
        }
    }
}
