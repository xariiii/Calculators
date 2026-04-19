namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOneByX = new Button();
            num7 = new Button();
            num4 = new Button();
            num1 = new Button();
            btnPlusMinus = new Button();
            btnPer = new Button();
            btnClearEntry = new Button();
            num0 = new Button();
            num2 = new Button();
            num5 = new Button();
            num8 = new Button();
            btnPov = new Button();
            btnClear = new Button();
            numDot = new Button();
            num3 = new Button();
            num6 = new Button();
            num9 = new Button();
            btnSqrt = new Button();
            btnClearLast = new Button();
            BtnEquals = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            ResultBox = new TextBox();
            ResultBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnOneByX
            // 
            btnOneByX.BackColor = Color.FromArgb(82, 82, 152);
            btnOneByX.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnOneByX.ForeColor = Color.White;
            btnOneByX.Location = new Point(12, 204);
            btnOneByX.Name = "btnOneByX";
            btnOneByX.Size = new Size(80, 80);
            btnOneByX.TabIndex = 0;
            btnOneByX.Text = "1/x";
            btnOneByX.UseVisualStyleBackColor = false;
            // 
            // num7
            // 
            num7.BackColor = Color.FromArgb(242, 242, 247);
            num7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num7.ForeColor = Color.FromArgb(82, 82, 152);
            num7.Location = new Point(12, 290);
            num7.Name = "num7";
            num7.Size = new Size(80, 80);
            num7.TabIndex = 1;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = false;
            num7.Click += btnNum_Click;
            // 
            // num4
            // 
            num4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num4.ForeColor = Color.FromArgb(82, 82, 152);
            num4.Location = new Point(12, 376);
            num4.Name = "num4";
            num4.Size = new Size(80, 80);
            num4.TabIndex = 2;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += btnNum_Click;
            // 
            // num1
            // 
            num1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num1.ForeColor = Color.FromArgb(82, 82, 152);
            num1.Location = new Point(12, 462);
            num1.Name = "num1";
            num1.Size = new Size(80, 80);
            num1.TabIndex = 3;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += btnNum_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.FromArgb(82, 82, 152);
            btnPlusMinus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnPlusMinus.ForeColor = Color.White;
            btnPlusMinus.Location = new Point(12, 548);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(80, 80);
            btnPlusMinus.TabIndex = 4;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = false;
            // 
            // btnPer
            // 
            btnPer.BackColor = Color.FromArgb(82, 82, 152);
            btnPer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnPer.ForeColor = Color.White;
            btnPer.Location = new Point(12, 118);
            btnPer.Name = "btnPer";
            btnPer.Size = new Size(80, 80);
            btnPer.TabIndex = 5;
            btnPer.Text = "%";
            btnPer.UseVisualStyleBackColor = false;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = Color.FromArgb(245, 149, 95);
            btnClearEntry.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnClearEntry.ForeColor = Color.White;
            btnClearEntry.Location = new Point(98, 118);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(80, 80);
            btnClearEntry.TabIndex = 11;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            // 
            // num0
            // 
            num0.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num0.ForeColor = Color.FromArgb(82, 82, 152);
            num0.Location = new Point(98, 548);
            num0.Name = "num0";
            num0.Size = new Size(80, 80);
            num0.TabIndex = 10;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += btnNum_Click;
            // 
            // num2
            // 
            num2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num2.ForeColor = Color.FromArgb(82, 82, 152);
            num2.Location = new Point(98, 462);
            num2.Name = "num2";
            num2.Size = new Size(80, 80);
            num2.TabIndex = 9;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += btnNum_Click;
            // 
            // num5
            // 
            num5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num5.ForeColor = Color.FromArgb(82, 82, 152);
            num5.Location = new Point(98, 376);
            num5.Name = "num5";
            num5.Size = new Size(80, 80);
            num5.TabIndex = 8;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += btnNum_Click;
            // 
            // num8
            // 
            num8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num8.ForeColor = Color.FromArgb(82, 82, 152);
            num8.Location = new Point(98, 290);
            num8.Name = "num8";
            num8.Size = new Size(80, 80);
            num8.TabIndex = 7;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += btnNum_Click;
            // 
            // btnPov
            // 
            btnPov.BackColor = Color.FromArgb(82, 82, 152);
            btnPov.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnPov.ForeColor = Color.White;
            btnPov.Location = new Point(98, 204);
            btnPov.Name = "btnPov";
            btnPov.Size = new Size(80, 80);
            btnPov.TabIndex = 6;
            btnPov.Text = "x²";
            btnPov.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(245, 149, 95);
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(184, 118);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 80);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // numDot
            // 
            numDot.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            numDot.ForeColor = Color.FromArgb(82, 82, 152);
            numDot.Location = new Point(184, 548);
            numDot.Name = "numDot";
            numDot.Size = new Size(80, 80);
            numDot.TabIndex = 16;
            numDot.Text = ".";
            numDot.UseVisualStyleBackColor = true;
            numDot.Click += btnNum_Click;
            // 
            // num3
            // 
            num3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num3.ForeColor = Color.FromArgb(82, 82, 152);
            num3.Location = new Point(184, 462);
            num3.Name = "num3";
            num3.Size = new Size(80, 80);
            num3.TabIndex = 15;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += btnNum_Click;
            // 
            // num6
            // 
            num6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num6.ForeColor = Color.FromArgb(82, 82, 152);
            num6.Location = new Point(184, 376);
            num6.Name = "num6";
            num6.Size = new Size(80, 80);
            num6.TabIndex = 14;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += btnNum_Click;
            // 
            // num9
            // 
            num9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            num9.ForeColor = Color.FromArgb(82, 82, 152);
            num9.Location = new Point(184, 290);
            num9.Name = "num9";
            num9.Size = new Size(80, 80);
            num9.TabIndex = 13;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += btnNum_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.FromArgb(82, 82, 152);
            btnSqrt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnSqrt.ForeColor = Color.White;
            btnSqrt.Location = new Point(184, 204);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(80, 80);
            btnSqrt.TabIndex = 12;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            // 
            // btnClearLast
            // 
            btnClearLast.BackColor = Color.FromArgb(245, 149, 95);
            btnClearLast.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnClearLast.ForeColor = Color.White;
            btnClearLast.Location = new Point(270, 118);
            btnClearLast.Name = "btnClearLast";
            btnClearLast.Size = new Size(80, 80);
            btnClearLast.TabIndex = 23;
            btnClearLast.Text = "<x";
            btnClearLast.UseVisualStyleBackColor = false;
            // 
            // BtnEquals
            // 
            BtnEquals.BackColor = Color.FromArgb(245, 149, 95);
            BtnEquals.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            BtnEquals.ForeColor = Color.White;
            BtnEquals.Location = new Point(270, 548);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(80, 80);
            BtnEquals.TabIndex = 22;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = false;
            BtnEquals.Click += BtnEquals_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(82, 82, 152);
            btnPlus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(270, 462);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(80, 80);
            btnPlus.TabIndex = 21;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += BtnMathOperation_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(82, 82, 152);
            btnMinus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(270, 376);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(80, 80);
            btnMinus.TabIndex = 20;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += BtnMathOperation_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.FromArgb(82, 82, 152);
            btnMul.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnMul.ForeColor = Color.White;
            btnMul.Location = new Point(270, 290);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(80, 80);
            btnMul.TabIndex = 19;
            btnMul.Text = "×";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += BtnMathOperation_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(82, 82, 152);
            btnDiv.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnDiv.ForeColor = Color.White;
            btnDiv.Location = new Point(270, 204);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(80, 80);
            btnDiv.TabIndex = 18;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += BtnMathOperation_Click;
            // 
            // ResultBox
            // 
            ResultBox.BackColor = Color.FromArgb(218, 218, 224);
            ResultBox.Enabled = false;
            ResultBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ResultBox.ForeColor = Color.FromArgb(82, 82, 152);
            ResultBox.Location = new Point(12, 62);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(338, 50);
            ResultBox.TabIndex = 24;
            // 
            // ResultBox2
            // 
            ResultBox2.BackColor = Color.FromArgb(218, 218, 224);
            ResultBox2.Enabled = false;
            ResultBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ResultBox2.ForeColor = Color.FromArgb(82, 82, 152);
            ResultBox2.Location = new Point(14, 36);
            ResultBox2.Multiline = true;
            ResultBox2.Name = "ResultBox2";
            ResultBox2.Size = new Size(338, 20);
            ResultBox2.TabIndex = 25;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 247);
            ClientSize = new Size(364, 641);
            Controls.Add(ResultBox2);
            Controls.Add(ResultBox);
            Controls.Add(btnClearLast);
            Controls.Add(BtnEquals);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnMul);
            Controls.Add(btnDiv);
            Controls.Add(btnClear);
            Controls.Add(numDot);
            Controls.Add(num3);
            Controls.Add(num6);
            Controls.Add(num9);
            Controls.Add(btnSqrt);
            Controls.Add(btnClearEntry);
            Controls.Add(num0);
            Controls.Add(num2);
            Controls.Add(num5);
            Controls.Add(num8);
            Controls.Add(btnPov);
            Controls.Add(btnPer);
            Controls.Add(btnPlusMinus);
            Controls.Add(num1);
            Controls.Add(num4);
            Controls.Add(num7);
            Controls.Add(btnOneByX);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOneByX;
        private Button num7;
        private Button num4;
        private Button num1;
        private Button btnPlusMinus;
        private Button btnPer;
        private Button btnClearEntry;
        private Button num0;
        private Button num2;
        private Button num5;
        private Button num8;
        private Button btnPov;
        private Button btnClear;
        private Button numDot;
        private Button num3;
        private Button num6;
        private Button num9;
        private Button btnSqrt;
        private Button btnClearLast;
        private Button BtnEquals;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMul;
        private Button btnDiv;
        private TextBox ResultBox;
        private TextBox ResultBox2;
    }
}
