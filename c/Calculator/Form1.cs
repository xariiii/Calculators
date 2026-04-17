using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
namespace Calculator
{
    public partial class Calculator : Form
    {
        //Fields
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;
        public Calculator()
        {
            InitializeComponent();
        }



        private void btnNum_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0" || enterValue) ResultBox.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!ResultBox.Text.Contains("."))
                    ResultBox.Text = ResultBox.Text + button.Text;
            }
            else ResultBox.Text = ResultBox.Text + button.Text;
        }

        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) BtnEquals.PerformClick();
            else result = Double.Parse(ResultBox.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;

            if (ResultBox.Text != "0")
            {
                ResultBox2.Text = fstNum + $"{result}{operation}";
                ResultBox.Text = string.Empty;

            }

        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secNum = ResultBox.Text;
            ResultBox2.Text = $"{ResultBox2.Text} {ResultBox.Text} =";

            if(ResultBox.Text != string.Empty)
            {
                if (ResultBox.Text == "0") ResultBox2.Text = string.Empty;

            }
        }
    }
}
