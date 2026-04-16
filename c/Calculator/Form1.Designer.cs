namespace Calculator
{
    partial class Calculator
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
            resultBox = new TextBox();
            numBtn7 = new Button();
            numBtn8 = new Button();
            addBtn = new Button();
            numBtn9 = new Button();
            subBtn = new Button();
            numBtn6 = new Button();
            numBtn5 = new Button();
            numBtn4 = new Button();
            mulBtn = new Button();
            numBtn3 = new Button();
            numBtn2 = new Button();
            numBtn1 = new Button();
            evalBtn = new Button();
            decBtn = new Button();
            clearEntryBtn = new Button();
            divBtn = new Button();
            numBtn0 = new Button();
            rightParaBtn = new Button();
            leftParaBtn = new Button();
            SuspendLayout();
            // 
            // resultBox
            // 
            resultBox.BackColor = Color.WhiteSmoke;
            resultBox.Enabled = false;
            resultBox.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            resultBox.Location = new Point(12, 12);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(318, 60);
            resultBox.TabIndex = 0;
            // 
            // numBtn7
            // 
            numBtn7.BackColor = Color.WhiteSmoke;
            numBtn7.Cursor = Cursors.Hand;
            numBtn7.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            numBtn7.Location = new Point(12, 159);
            numBtn7.Margin = new Padding(0);
            numBtn7.Name = "numBtn7";
            numBtn7.Size = new Size(75, 75);
            numBtn7.TabIndex = 1;
            numBtn7.Text = "7";
            numBtn7.UseVisualStyleBackColor = false;
            numBtn7.Click += AppendToCalculationString;
            // 
            // numBtn8
            // 
            numBtn8.BackColor = Color.WhiteSmoke;
            numBtn8.Cursor = Cursors.Hand;
            numBtn8.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            numBtn8.Location = new Point(93, 159);
            numBtn8.Margin = new Padding(0);
            numBtn8.Name = "numBtn8";
            numBtn8.Size = new Size(75, 75);
            numBtn8.TabIndex = 2;
            numBtn8.Text = "8";
            numBtn8.UseVisualStyleBackColor = false;
            numBtn8.Click += AppendToCalculationString;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LightGray;
            addBtn.Cursor = Cursors.Hand;
            addBtn.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            addBtn.Location = new Point(255, 78);
            addBtn.Margin = new Padding(0);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 75);
            addBtn.TabIndex = 4;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += AppendToCalculationString;
            // 
            // numBtn9
            // 
            numBtn9.BackColor = Color.WhiteSmoke;
            numBtn9.Cursor = Cursors.Hand;
            numBtn9.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            numBtn9.Location = new Point(176, 159);
            numBtn9.Margin = new Padding(0);
            numBtn9.Name = "numBtn9";
            numBtn9.Size = new Size(75, 75);
            numBtn9.TabIndex = 3;
            numBtn9.Text = "9";
            numBtn9.UseVisualStyleBackColor = false;
            numBtn9.Click += AppendToCalculationString;
            // 
            // subBtn
            // 
            subBtn.BackColor = Color.LightGray;
            subBtn.Cursor = Cursors.Hand;
            subBtn.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            subBtn.Location = new Point(255, 159);
            subBtn.Margin = new Padding(0);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(75, 75);
            subBtn.TabIndex = 8;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = false;
            subBtn.Click += AppendToCalculationString;
            // 
            // numBtn6
            // 
            numBtn6.BackColor = Color.WhiteSmoke;
            numBtn6.Cursor = Cursors.Hand;
            numBtn6.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            numBtn6.Location = new Point(176, 240);
            numBtn6.Margin = new Padding(0);
            numBtn6.Name = "numBtn6";
            numBtn6.Size = new Size(75, 75);
            numBtn6.TabIndex = 7;
            numBtn6.Text = "6";
            numBtn6.UseVisualStyleBackColor = false;
            numBtn6.Click += AppendToCalculationString;
            // 
            // numBtn5
            // 
            numBtn5.BackColor = Color.WhiteSmoke;
            numBtn5.Cursor = Cursors.Hand;
            numBtn5.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            numBtn5.Location = new Point(93, 240);
            numBtn5.Margin = new Padding(0);
            numBtn5.Name = "numBtn5";
            numBtn5.Size = new Size(75, 75);
            numBtn5.TabIndex = 6;
            numBtn5.Text = "5";
            numBtn5.UseVisualStyleBackColor = false;
            numBtn5.Click += AppendToCalculationString;
            // 
            // numBtn4
            // 
            numBtn4.BackColor = Color.WhiteSmoke;
            numBtn4.Cursor = Cursors.Hand;
            numBtn4.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            numBtn4.Location = new Point(12, 240);
            numBtn4.Margin = new Padding(0);
            numBtn4.Name = "numBtn4";
            numBtn4.Size = new Size(75, 75);
            numBtn4.TabIndex = 5;
            numBtn4.Text = "4";
            numBtn4.UseVisualStyleBackColor = false;
            numBtn4.Click += AppendToCalculationString;
            // 
            // mulBtn
            // 
            mulBtn.BackColor = Color.LightGray;
            mulBtn.Cursor = Cursors.Hand;
            mulBtn.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            mulBtn.Location = new Point(255, 240);
            mulBtn.Margin = new Padding(0);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(75, 75);
            mulBtn.TabIndex = 12;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = false;
            mulBtn.Click += AppendToCalculationString;
            // 
            // numBtn3
            // 
            numBtn3.BackColor = Color.WhiteSmoke;
            numBtn3.Cursor = Cursors.Hand;
            numBtn3.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            numBtn3.Location = new Point(176, 321);
            numBtn3.Margin = new Padding(0);
            numBtn3.Name = "numBtn3";
            numBtn3.Size = new Size(75, 75);
            numBtn3.TabIndex = 11;
            numBtn3.Text = "3";
            numBtn3.UseVisualStyleBackColor = false;
            numBtn3.Click += AppendToCalculationString;
            // 
            // numBtn2
            // 
            numBtn2.BackColor = Color.WhiteSmoke;
            numBtn2.Cursor = Cursors.Hand;
            numBtn2.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            numBtn2.Location = new Point(93, 321);
            numBtn2.Margin = new Padding(0);
            numBtn2.Name = "numBtn2";
            numBtn2.Size = new Size(75, 75);
            numBtn2.TabIndex = 10;
            numBtn2.Text = "2";
            numBtn2.UseVisualStyleBackColor = false;
            numBtn2.Click += AppendToCalculationString;
            // 
            // numBtn1
            // 
            numBtn1.BackColor = Color.WhiteSmoke;
            numBtn1.Cursor = Cursors.Hand;
            numBtn1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            numBtn1.Location = new Point(12, 321);
            numBtn1.Margin = new Padding(0);
            numBtn1.Name = "numBtn1";
            numBtn1.Size = new Size(75, 75);
            numBtn1.TabIndex = 9;
            numBtn1.Text = "1";
            numBtn1.UseVisualStyleBackColor = false;
            numBtn1.Click += AppendToCalculationString;
            // 
            // evalBtn
            // 
            evalBtn.BackColor = Color.FromArgb(191, 128, 255);
            evalBtn.Cursor = Cursors.Hand;
            evalBtn.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            evalBtn.Location = new Point(174, 402);
            evalBtn.Margin = new Padding(0);
            evalBtn.Name = "evalBtn";
            evalBtn.Size = new Size(156, 75);
            evalBtn.TabIndex = 16;
            evalBtn.Text = "=";
            evalBtn.UseVisualStyleBackColor = false;
            evalBtn.Click += EvaluateCalculation;
            // 
            // decBtn
            // 
            decBtn.BackColor = Color.WhiteSmoke;
            decBtn.Cursor = Cursors.Hand;
            decBtn.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            decBtn.Location = new Point(12, 402);
            decBtn.Margin = new Padding(0);
            decBtn.Name = "decBtn";
            decBtn.Size = new Size(75, 75);
            decBtn.TabIndex = 14;
            decBtn.Text = ".";
            decBtn.UseVisualStyleBackColor = false;
            decBtn.Click += AppendToCalculationString;
            // 
            // clearEntryBtn
            // 
            clearEntryBtn.BackColor = Color.FromArgb(191, 128, 255);
            clearEntryBtn.Cursor = Cursors.Hand;
            clearEntryBtn.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            clearEntryBtn.Location = new Point(12, 78);
            clearEntryBtn.Margin = new Padding(0);
            clearEntryBtn.Name = "clearEntryBtn";
            clearEntryBtn.Size = new Size(75, 75);
            clearEntryBtn.TabIndex = 13;
            clearEntryBtn.Text = "CE";
            clearEntryBtn.UseVisualStyleBackColor = false;
            clearEntryBtn.Click += ClearEntry;
            // 
            // divBtn
            // 
            divBtn.BackColor = Color.LightGray;
            divBtn.Cursor = Cursors.Hand;
            divBtn.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            divBtn.Location = new Point(255, 321);
            divBtn.Margin = new Padding(0);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(75, 75);
            divBtn.TabIndex = 20;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = false;
            divBtn.Click += AppendToCalculationString;
            // 
            // numBtn0
            // 
            numBtn0.BackColor = Color.WhiteSmoke;
            numBtn0.Cursor = Cursors.Hand;
            numBtn0.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            numBtn0.Location = new Point(93, 402);
            numBtn0.Margin = new Padding(0);
            numBtn0.Name = "numBtn0";
            numBtn0.Size = new Size(75, 75);
            numBtn0.TabIndex = 19;
            numBtn0.Text = "0";
            numBtn0.UseVisualStyleBackColor = false;
            numBtn0.Click += AppendToCalculationString;
            // 
            // rightParaBtn
            // 
            rightParaBtn.BackColor = Color.LightGray;
            rightParaBtn.Cursor = Cursors.Hand;
            rightParaBtn.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            rightParaBtn.Location = new Point(176, 78);
            rightParaBtn.Margin = new Padding(0);
            rightParaBtn.Name = "rightParaBtn";
            rightParaBtn.Size = new Size(75, 75);
            rightParaBtn.TabIndex = 18;
            rightParaBtn.Text = ")";
            rightParaBtn.UseVisualStyleBackColor = false;
            rightParaBtn.Click += AppendToCalculationString;
            // 
            // leftParaBtn
            // 
            leftParaBtn.BackColor = Color.LightGray;
            leftParaBtn.Cursor = Cursors.Hand;
            leftParaBtn.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold);
            leftParaBtn.Location = new Point(93, 78);
            leftParaBtn.Margin = new Padding(0);
            leftParaBtn.Name = "leftParaBtn";
            leftParaBtn.Size = new Size(75, 75);
            leftParaBtn.TabIndex = 17;
            leftParaBtn.Text = "(";
            leftParaBtn.UseVisualStyleBackColor = false;
            leftParaBtn.Click += AppendToCalculationString;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 57, 125);
            ClientSize = new Size(344, 491);
            Controls.Add(divBtn);
            Controls.Add(numBtn0);
            Controls.Add(rightParaBtn);
            Controls.Add(leftParaBtn);
            Controls.Add(evalBtn);
            Controls.Add(decBtn);
            Controls.Add(clearEntryBtn);
            Controls.Add(mulBtn);
            Controls.Add(numBtn3);
            Controls.Add(numBtn2);
            Controls.Add(numBtn1);
            Controls.Add(subBtn);
            Controls.Add(numBtn6);
            Controls.Add(numBtn5);
            Controls.Add(numBtn4);
            Controls.Add(addBtn);
            Controls.Add(numBtn9);
            Controls.Add(numBtn8);
            Controls.Add(numBtn7);
            Controls.Add(resultBox);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultBox;
        private Button numBtn7;
        private Button numBtn8;
        private Button addBtn;
        private Button numBtn9;
        private Button subBtn;
        private Button numBtn6;
        private Button numBtn5;
        private Button numBtn4;
        private Button mulBtn;
        private Button numBtn3;
        private Button numBtn2;
        private Button numBtn1;
        private Button evalBtn;
        private Button decBtn;
        private Button clearEntryBtn;
        private Button divBtn;
        private Button numBtn0;
        private Button rightParaBtn;
        private Button leftParaBtn;
    }
}
