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
            resultBox.Enabled = false;
            resultBox.Location = new Point(12, 12);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(318, 60);
            resultBox.TabIndex = 0;
            // 
            // numBtn7
            // 
            numBtn7.Cursor = Cursors.Hand;
            numBtn7.Location = new Point(12, 78);
            numBtn7.Name = "numBtn7";
            numBtn7.Size = new Size(75, 75);
            numBtn7.TabIndex = 1;
            numBtn7.Text = "7";
            numBtn7.UseVisualStyleBackColor = true;
            numBtn7.Click += AppendToCalculationString;
            // 
            // numBtn8
            // 
            numBtn8.Cursor = Cursors.Hand;
            numBtn8.Location = new Point(93, 78);
            numBtn8.Name = "numBtn8";
            numBtn8.Size = new Size(75, 75);
            numBtn8.TabIndex = 2;
            numBtn8.Text = "8";
            numBtn8.UseVisualStyleBackColor = true;
            numBtn8.Click += AppendToCalculationString;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.Location = new Point(255, 78);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 75);
            addBtn.TabIndex = 4;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += AppendToCalculationString;
            // 
            // numBtn9
            // 
            numBtn9.Cursor = Cursors.Hand;
            numBtn9.Location = new Point(174, 78);
            numBtn9.Name = "numBtn9";
            numBtn9.Size = new Size(75, 75);
            numBtn9.TabIndex = 3;
            numBtn9.Text = "9";
            numBtn9.UseVisualStyleBackColor = true;
            numBtn9.Click += AppendToCalculationString;
            // 
            // subBtn
            // 
            subBtn.Cursor = Cursors.Hand;
            subBtn.Location = new Point(255, 159);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(75, 75);
            subBtn.TabIndex = 8;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Click += AppendToCalculationString;
            // 
            // numBtn6
            // 
            numBtn6.Cursor = Cursors.Hand;
            numBtn6.Location = new Point(174, 159);
            numBtn6.Name = "numBtn6";
            numBtn6.Size = new Size(75, 75);
            numBtn6.TabIndex = 7;
            numBtn6.Text = "6";
            numBtn6.UseVisualStyleBackColor = true;
            numBtn6.Click += AppendToCalculationString;
            // 
            // numBtn5
            // 
            numBtn5.Cursor = Cursors.Hand;
            numBtn5.Location = new Point(93, 159);
            numBtn5.Name = "numBtn5";
            numBtn5.Size = new Size(75, 75);
            numBtn5.TabIndex = 6;
            numBtn5.Text = "5";
            numBtn5.UseVisualStyleBackColor = true;
            numBtn5.Click += AppendToCalculationString;
            // 
            // numBtn4
            // 
            numBtn4.Cursor = Cursors.Hand;
            numBtn4.Location = new Point(12, 159);
            numBtn4.Name = "numBtn4";
            numBtn4.Size = new Size(75, 75);
            numBtn4.TabIndex = 5;
            numBtn4.Text = "4";
            numBtn4.UseVisualStyleBackColor = true;
            numBtn4.Click += AppendToCalculationString;
            // 
            // mulBtn
            // 
            mulBtn.Cursor = Cursors.Hand;
            mulBtn.Location = new Point(255, 240);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(75, 75);
            mulBtn.TabIndex = 12;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = true;
            mulBtn.Click += AppendToCalculationString;
            // 
            // numBtn3
            // 
            numBtn3.Cursor = Cursors.Hand;
            numBtn3.Location = new Point(174, 240);
            numBtn3.Name = "numBtn3";
            numBtn3.Size = new Size(75, 75);
            numBtn3.TabIndex = 11;
            numBtn3.Text = "3";
            numBtn3.UseVisualStyleBackColor = true;
            numBtn3.Click += AppendToCalculationString;
            // 
            // numBtn2
            // 
            numBtn2.Cursor = Cursors.Hand;
            numBtn2.Location = new Point(93, 240);
            numBtn2.Name = "numBtn2";
            numBtn2.Size = new Size(75, 75);
            numBtn2.TabIndex = 10;
            numBtn2.Text = "2";
            numBtn2.UseVisualStyleBackColor = true;
            numBtn2.Click += AppendToCalculationString;
            // 
            // numBtn1
            // 
            numBtn1.Cursor = Cursors.Hand;
            numBtn1.Location = new Point(12, 240);
            numBtn1.Name = "numBtn1";
            numBtn1.Size = new Size(75, 75);
            numBtn1.TabIndex = 9;
            numBtn1.Text = "1";
            numBtn1.UseVisualStyleBackColor = true;
            numBtn1.Click += AppendToCalculationString;
            // 
            // evalBtn
            // 
            evalBtn.Cursor = Cursors.Hand;
            evalBtn.Location = new Point(174, 402);
            evalBtn.Name = "evalBtn";
            evalBtn.Size = new Size(156, 75);
            evalBtn.TabIndex = 16;
            evalBtn.Text = "=";
            evalBtn.UseVisualStyleBackColor = true;
            // 
            // decBtn
            // 
            decBtn.Cursor = Cursors.Hand;
            decBtn.Location = new Point(93, 402);
            decBtn.Name = "decBtn";
            decBtn.Size = new Size(75, 75);
            decBtn.TabIndex = 14;
            decBtn.Text = ".";
            decBtn.UseVisualStyleBackColor = true;
            decBtn.Click += AppendToCalculationString;
            // 
            // clearEntryBtn
            // 
            clearEntryBtn.Cursor = Cursors.Hand;
            clearEntryBtn.Location = new Point(12, 402);
            clearEntryBtn.Name = "clearEntryBtn";
            clearEntryBtn.Size = new Size(75, 75);
            clearEntryBtn.TabIndex = 13;
            clearEntryBtn.Text = "CE";
            clearEntryBtn.UseVisualStyleBackColor = true;
            // 
            // divBtn
            // 
            divBtn.Cursor = Cursors.Hand;
            divBtn.Location = new Point(255, 321);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(75, 75);
            divBtn.TabIndex = 20;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = true;
            divBtn.Click += AppendToCalculationString;
            // 
            // numBtn0
            // 
            numBtn0.Cursor = Cursors.Hand;
            numBtn0.Location = new Point(174, 321);
            numBtn0.Name = "numBtn0";
            numBtn0.Size = new Size(75, 75);
            numBtn0.TabIndex = 19;
            numBtn0.Text = "0";
            numBtn0.UseVisualStyleBackColor = true;
            numBtn0.Click += AppendToCalculationString;
            // 
            // rightParaBtn
            // 
            rightParaBtn.Cursor = Cursors.Hand;
            rightParaBtn.Location = new Point(93, 321);
            rightParaBtn.Name = "rightParaBtn";
            rightParaBtn.Size = new Size(75, 75);
            rightParaBtn.TabIndex = 18;
            rightParaBtn.Text = ")";
            rightParaBtn.UseVisualStyleBackColor = true;
            rightParaBtn.Click += AppendToCalculationString;
            // 
            // leftParaBtn
            // 
            leftParaBtn.Cursor = Cursors.Hand;
            leftParaBtn.Location = new Point(12, 321);
            leftParaBtn.Name = "leftParaBtn";
            leftParaBtn.Size = new Size(75, 75);
            leftParaBtn.TabIndex = 17;
            leftParaBtn.Text = "(";
            leftParaBtn.UseVisualStyleBackColor = true;
            leftParaBtn.Click += AppendToCalculationString;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
