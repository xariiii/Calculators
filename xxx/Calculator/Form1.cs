namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNum_Click(object sender, EventArgs e)
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

            if (ResultBox.Text != "0")
            {
                ResultBox2.Text = fstNum = $"{result} {operation}";
                ResultBox.Text = string.Empty;
            }


        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secNum = ResultBox.Text;
            ResultBox2.Text = $"{ResultBox2.Text} {ResultBox.Text} =";
            if (ResultBox.Text != string.Empty)
            {
                if (ResultBox.Text == "0") ResultBox2.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        ResultBox.Text = (result + Double.Parse(ResultBox.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={ResultBox.Text}\n");
                        break;
                    case "-":
                        ResultBox.Text = (result - Double.Parse(ResultBox.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={ResultBox.Text}\n");
                        break;
                    case "×":
                        ResultBox.Text = (result * Double.Parse(ResultBox.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={ResultBox.Text}\n");
                        break;
                    case "÷":
                        ResultBox.Text = (result / Double.Parse(ResultBox.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={ResultBox.Text}\n");
                        break;
                    default:
                        ResultBox2.Text = $"{ResultBox.Text} =";
                        break;
                }

                result = Double.Parse(ResultBox.Text);
                operation = string.Empty;
            }



        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 345 : 5;
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            if (RtBoxDisplayHistory.Text == string.Empty)
                RtBoxDisplayHistory.Text = "There's no history yet";
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length > 0)
                ResultBox.Text = ResultBox.Text.Remove(ResultBox.Text.Length - 1, 1);
            if (ResultBox.Text == string.Empty)
                ResultBox.Text = "0";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            ResultBox2.Text = string.Empty;
            result = 0;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }

        private void BtnOperations_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            switch (operation)
            {
                case "√":
                    ResultBox2.Text = $"√({ResultBox.Text})";
                    ResultBox.Text = Convert.ToString(Math.Sqrt(Double.Parse(ResultBox.Text)));
                    break;
                case "x²":
                    ResultBox2.Text = $"({ResultBox.Text})²";
                    ResultBox.Text = Convert.ToString(Convert.ToDouble(ResultBox.Text) * Convert.ToDouble(ResultBox.Text));
                    break;
                case "1/x":
                    ResultBox2.Text = $"1/x({ResultBox.Text})";
                    ResultBox.Text = Convert.ToString(1.0 / Convert.ToDouble(ResultBox.Text));
                    break;
                case "%":
                    ResultBox2.Text = $"%({ResultBox.Text})";
                    ResultBox.Text = Convert.ToString(Convert.ToDouble(ResultBox.Text) / Convert.ToDouble(100));
                    break;
                case "+/-":
                    ResultBox.Text = Convert.ToString(-1 * Convert.ToDouble(ResultBox.Text));
                    break;
                
            }
            RtBoxDisplayHistory.AppendText($"{ResultBox2.Text}={ResultBox.Text}\n");
        }
    }
}
