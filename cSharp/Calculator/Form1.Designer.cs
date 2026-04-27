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
            PnlTitle = new Panel();
            PnlHistory = new Panel();
            RtBoxDisplayHistory = new RichTextBox();
            BtnClearHistory = new Button();
            panel1 = new Panel();
            BtnHistory = new Button();
            ResultBox2 = new TextBox();
            ResultBox = new TextBox();
            textBox1 = new TextBox();
            BtnBackSpace = new Button();
            BtnClear = new Button();
            BtnClearEntry = new Button();
            BtnPercent = new Button();
            Btn1X = new Button();
            BtnPov = new Button();
            BtnSqrt = new Button();
            BtnDiv = new Button();
            Btn7 = new Button();
            Btn8 = new Button();
            Btn9 = new Button();
            BtnMul = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            BtnSub = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            BtnAdd = new Button();
            BtnPM = new Button();
            Btn0 = new Button();
            BtnDesimal = new Button();
            BtnEquals = new Button();
            PnlHistory.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTitle
            // 
            PnlTitle.Dock = DockStyle.Top;
            PnlTitle.Location = new Point(0, 0);
            PnlTitle.Margin = new Padding(0);
            PnlTitle.Name = "PnlTitle";
            PnlTitle.Size = new Size(334, 12);
            PnlTitle.TabIndex = 0;
            // 
            // PnlHistory
            // 
            PnlHistory.Controls.Add(RtBoxDisplayHistory);
            PnlHistory.Controls.Add(BtnClearHistory);
            PnlHistory.Dock = DockStyle.Bottom;
            PnlHistory.Location = new Point(0, 661);
            PnlHistory.Margin = new Padding(0);
            PnlHistory.Name = "PnlHistory";
            PnlHistory.Size = new Size(334, 5);
            PnlHistory.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            RtBoxDisplayHistory.BackColor = Color.FromArgb(242, 242, 247);
            RtBoxDisplayHistory.BorderStyle = BorderStyle.None;
            RtBoxDisplayHistory.Dock = DockStyle.Fill;
            RtBoxDisplayHistory.Location = new Point(0, 0);
            RtBoxDisplayHistory.Margin = new Padding(3, 6, 3, 3);
            RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            RtBoxDisplayHistory.ScrollBars = RichTextBoxScrollBars.Horizontal;
            RtBoxDisplayHistory.Size = new Size(334, 0);
            RtBoxDisplayHistory.TabIndex = 2;
            RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            BtnClearHistory.BackColor = Color.FromArgb(242, 242, 247);
            BtnClearHistory.Dock = DockStyle.Bottom;
            BtnClearHistory.Location = new Point(0, -26);
            BtnClearHistory.Name = "BtnClearHistory";
            BtnClearHistory.Size = new Size(334, 31);
            BtnClearHistory.TabIndex = 1;
            BtnClearHistory.UseVisualStyleBackColor = false;
            BtnClearHistory.Click += BtnClearHistory_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnHistory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 12);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 40);
            panel1.TabIndex = 2;
            // 
            // BtnHistory
            // 
            BtnHistory.BackColor = Color.FromArgb(245, 149, 95);
            BtnHistory.Dock = DockStyle.Right;
            BtnHistory.Font = new Font("Segoe UI", 9.75F);
            BtnHistory.ForeColor = Color.FromArgb(242, 242, 247);
            BtnHistory.Location = new Point(294, 0);
            BtnHistory.Margin = new Padding(0);
            BtnHistory.Name = "BtnHistory";
            BtnHistory.Size = new Size(40, 40);
            BtnHistory.TabIndex = 0;
            BtnHistory.Text = "⟲";
            BtnHistory.UseVisualStyleBackColor = false;
            BtnHistory.Click += BtnHistory_Click;
            // 
            // ResultBox2
            // 
            ResultBox2.BackColor = Color.FromArgb(242, 242, 247);
            ResultBox2.Dock = DockStyle.Top;
            ResultBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ResultBox2.ForeColor = Color.FromArgb(82, 82, 152);
            ResultBox2.Location = new Point(0, 52);
            ResultBox2.Margin = new Padding(0);
            ResultBox2.Multiline = true;
            ResultBox2.Name = "ResultBox2";
            ResultBox2.Size = new Size(334, 40);
            ResultBox2.TabIndex = 3;
            ResultBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // ResultBox
            // 
            ResultBox.BackColor = Color.FromArgb(242, 242, 247);
            ResultBox.Dock = DockStyle.Top;
            ResultBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ResultBox.ForeColor = Color.FromArgb(82, 82, 152);
            ResultBox.Location = new Point(0, 92);
            ResultBox.Margin = new Padding(0);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(334, 40);
            ResultBox.TabIndex = 4;
            ResultBox.Text = "0";
            ResultBox.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(242, 242, 247);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(82, 82, 152);
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 666);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // BtnBackSpace
            // 
            BtnBackSpace.BackColor = Color.FromArgb(245, 149, 95);
            BtnBackSpace.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnBackSpace.ForeColor = Color.FromArgb(242, 242, 247);
            BtnBackSpace.Location = new Point(251, 172);
            BtnBackSpace.Name = "BtnBackSpace";
            BtnBackSpace.Size = new Size(75, 75);
            BtnBackSpace.TabIndex = 10;
            BtnBackSpace.Text = "DEL";
            BtnBackSpace.UseVisualStyleBackColor = false;
            BtnBackSpace.Click += BtnBackSpace_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(245, 149, 95);
            BtnClear.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnClear.ForeColor = Color.FromArgb(242, 242, 247);
            BtnClear.Location = new Point(170, 172);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 75);
            BtnClear.TabIndex = 11;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnC_Click;
            // 
            // BtnClearEntry
            // 
            BtnClearEntry.BackColor = Color.FromArgb(245, 149, 95);
            BtnClearEntry.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnClearEntry.ForeColor = Color.FromArgb(242, 242, 247);
            BtnClearEntry.Location = new Point(89, 172);
            BtnClearEntry.Name = "BtnClearEntry";
            BtnClearEntry.Size = new Size(75, 75);
            BtnClearEntry.TabIndex = 12;
            BtnClearEntry.Text = "CE";
            BtnClearEntry.UseVisualStyleBackColor = false;
            BtnClearEntry.Click += BtnCE_Click;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = Color.FromArgb(82, 82, 152);
            BtnPercent.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnPercent.ForeColor = Color.FromArgb(242, 242, 247);
            BtnPercent.Location = new Point(8, 172);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(75, 75);
            BtnPercent.TabIndex = 13;
            BtnPercent.Text = "%";
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += BtnOperations_Click;
            // 
            // Btn1X
            // 
            Btn1X.BackColor = Color.FromArgb(82, 82, 152);
            Btn1X.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn1X.ForeColor = Color.FromArgb(242, 242, 247);
            Btn1X.Location = new Point(8, 253);
            Btn1X.Name = "Btn1X";
            Btn1X.Size = new Size(75, 75);
            Btn1X.TabIndex = 17;
            Btn1X.Text = "1/x";
            Btn1X.UseVisualStyleBackColor = false;
            Btn1X.Click += BtnOperations_Click;
            // 
            // BtnPov
            // 
            BtnPov.BackColor = Color.FromArgb(82, 82, 152);
            BtnPov.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnPov.ForeColor = Color.FromArgb(242, 242, 247);
            BtnPov.Location = new Point(89, 253);
            BtnPov.Name = "BtnPov";
            BtnPov.Size = new Size(75, 75);
            BtnPov.TabIndex = 16;
            BtnPov.Text = "x²";
            BtnPov.UseVisualStyleBackColor = false;
            BtnPov.Click += BtnOperations_Click;
            // 
            // BtnSqrt
            // 
            BtnSqrt.BackColor = Color.FromArgb(82, 82, 152);
            BtnSqrt.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            BtnSqrt.ForeColor = Color.FromArgb(242, 242, 247);
            BtnSqrt.Location = new Point(170, 253);
            BtnSqrt.Name = "BtnSqrt";
            BtnSqrt.Size = new Size(75, 75);
            BtnSqrt.TabIndex = 15;
            BtnSqrt.Text = "√x";
            BtnSqrt.UseVisualStyleBackColor = false;
            BtnSqrt.Click += BtnOperations_Click;
            // 
            // BtnDiv
            // 
            BtnDiv.BackColor = Color.FromArgb(82, 82, 152);
            BtnDiv.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnDiv.ForeColor = Color.FromArgb(242, 242, 247);
            BtnDiv.Location = new Point(251, 253);
            BtnDiv.Name = "BtnDiv";
            BtnDiv.Size = new Size(75, 75);
            BtnDiv.TabIndex = 14;
            BtnDiv.Text = "÷";
            BtnDiv.UseVisualStyleBackColor = false;
            BtnDiv.Click += BtnMathOperation_Click;
            // 
            // Btn7
            // 
            Btn7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn7.ForeColor = Color.FromArgb(82, 82, 152);
            Btn7.Location = new Point(8, 334);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(75, 75);
            Btn7.TabIndex = 21;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += BtnNum_Click;
            // 
            // Btn8
            // 
            Btn8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn8.ForeColor = Color.FromArgb(82, 82, 152);
            Btn8.Location = new Point(89, 334);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(75, 75);
            Btn8.TabIndex = 20;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += BtnNum_Click;
            // 
            // Btn9
            // 
            Btn9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn9.ForeColor = Color.FromArgb(82, 82, 152);
            Btn9.Location = new Point(170, 334);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(75, 75);
            Btn9.TabIndex = 19;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += BtnNum_Click;
            // 
            // BtnMul
            // 
            BtnMul.BackColor = Color.FromArgb(82, 82, 152);
            BtnMul.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnMul.ForeColor = Color.FromArgb(242, 242, 247);
            BtnMul.Location = new Point(251, 334);
            BtnMul.Name = "BtnMul";
            BtnMul.Size = new Size(75, 75);
            BtnMul.TabIndex = 18;
            BtnMul.Text = "×";
            BtnMul.UseVisualStyleBackColor = false;
            BtnMul.Click += BtnMathOperation_Click;
            // 
            // Btn4
            // 
            Btn4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn4.ForeColor = Color.FromArgb(82, 82, 152);
            Btn4.Location = new Point(8, 415);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(75, 75);
            Btn4.TabIndex = 25;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += BtnNum_Click;
            // 
            // Btn5
            // 
            Btn5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn5.ForeColor = Color.FromArgb(82, 82, 152);
            Btn5.Location = new Point(89, 415);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(75, 75);
            Btn5.TabIndex = 24;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += BtnNum_Click;
            // 
            // Btn6
            // 
            Btn6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn6.ForeColor = Color.FromArgb(82, 82, 152);
            Btn6.Location = new Point(170, 415);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(75, 75);
            Btn6.TabIndex = 23;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += BtnNum_Click;
            // 
            // BtnSub
            // 
            BtnSub.BackColor = Color.FromArgb(82, 82, 152);
            BtnSub.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnSub.ForeColor = Color.FromArgb(242, 242, 247);
            BtnSub.Location = new Point(251, 415);
            BtnSub.Name = "BtnSub";
            BtnSub.Size = new Size(75, 75);
            BtnSub.TabIndex = 22;
            BtnSub.Text = "-";
            BtnSub.UseVisualStyleBackColor = false;
            BtnSub.Click += BtnMathOperation_Click;
            // 
            // Btn1
            // 
            Btn1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn1.ForeColor = Color.FromArgb(82, 82, 152);
            Btn1.Location = new Point(8, 496);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(75, 75);
            Btn1.TabIndex = 29;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += BtnNum_Click;
            // 
            // Btn2
            // 
            Btn2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn2.ForeColor = Color.FromArgb(82, 82, 152);
            Btn2.Location = new Point(89, 496);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(75, 75);
            Btn2.TabIndex = 28;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += BtnNum_Click;
            // 
            // Btn3
            // 
            Btn3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn3.ForeColor = Color.FromArgb(82, 82, 152);
            Btn3.Location = new Point(170, 496);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(75, 75);
            Btn3.TabIndex = 27;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += BtnNum_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(82, 82, 152);
            BtnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnAdd.ForeColor = Color.FromArgb(242, 242, 247);
            BtnAdd.Location = new Point(251, 496);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 75);
            BtnAdd.TabIndex = 26;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnMathOperation_Click;
            // 
            // BtnPM
            // 
            BtnPM.BackColor = Color.FromArgb(82, 82, 152);
            BtnPM.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnPM.ForeColor = Color.FromArgb(242, 242, 247);
            BtnPM.Location = new Point(8, 577);
            BtnPM.Name = "BtnPM";
            BtnPM.Size = new Size(75, 75);
            BtnPM.TabIndex = 33;
            BtnPM.Text = "+/-";
            BtnPM.UseVisualStyleBackColor = false;
            BtnPM.Click += BtnOperations_Click;
            // 
            // Btn0
            // 
            Btn0.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            Btn0.ForeColor = Color.FromArgb(82, 82, 152);
            Btn0.Location = new Point(89, 577);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(75, 75);
            Btn0.TabIndex = 32;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += BtnNum_Click;
            // 
            // BtnDesimal
            // 
            BtnDesimal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnDesimal.ForeColor = Color.FromArgb(82, 82, 152);
            BtnDesimal.Location = new Point(170, 577);
            BtnDesimal.Name = "BtnDesimal";
            BtnDesimal.Size = new Size(75, 75);
            BtnDesimal.TabIndex = 31;
            BtnDesimal.Text = ",";
            BtnDesimal.UseVisualStyleBackColor = true;
            BtnDesimal.Click += BtnNum_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.BackColor = Color.FromArgb(245, 149, 95);
            BtnEquals.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            BtnEquals.ForeColor = Color.FromArgb(242, 242, 247);
            BtnEquals.Location = new Point(251, 577);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(75, 75);
            BtnEquals.TabIndex = 30;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = false;
            BtnEquals.Click += BtnEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 247);
            ClientSize = new Size(334, 666);
            Controls.Add(PnlHistory);
            Controls.Add(ResultBox);
            Controls.Add(ResultBox2);
            Controls.Add(panel1);
            Controls.Add(PnlTitle);
            Controls.Add(BtnPM);
            Controls.Add(Btn0);
            Controls.Add(BtnDesimal);
            Controls.Add(BtnEquals);
            Controls.Add(Btn1);
            Controls.Add(Btn2);
            Controls.Add(Btn3);
            Controls.Add(BtnAdd);
            Controls.Add(Btn4);
            Controls.Add(Btn5);
            Controls.Add(Btn6);
            Controls.Add(BtnSub);
            Controls.Add(Btn7);
            Controls.Add(Btn8);
            Controls.Add(Btn9);
            Controls.Add(BtnMul);
            Controls.Add(Btn1X);
            Controls.Add(BtnPov);
            Controls.Add(BtnSqrt);
            Controls.Add(BtnDiv);
            Controls.Add(BtnPercent);
            Controls.Add(BtnClearEntry);
            Controls.Add(BtnClear);
            Controls.Add(BtnBackSpace);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Calculator";
            PnlHistory.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlTitle;
        private Panel PnlHistory;
        private Panel panel1;
        private Button BtnHistory;
        private TextBox ResultBox2;
        private TextBox ResultBox;
        private TextBox textBox1;
        private Button BtnBackSpace;
        private Button BtnClear;
        private Button BtnClearEntry;
        private Button BtnPercent;
        private Button Btn1X;
        private Button BtnPov;
        private Button BtnSqrt;
        private Button BtnDiv;
        private Button Btn7;
        private Button Btn8;
        private Button Btn9;
        private Button BtnMul;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button BtnSub;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button BtnAdd;
        private Button BtnPM;
        private Button Btn0;
        private Button BtnDesimal;
        private Button BtnEquals;
        private Button BtnClearHistory;
        private RichTextBox RtBoxDisplayHistory;
    }
}
