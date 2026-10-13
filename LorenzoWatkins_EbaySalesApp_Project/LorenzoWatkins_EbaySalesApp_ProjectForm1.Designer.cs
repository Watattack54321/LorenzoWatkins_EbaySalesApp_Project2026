namespace LorenzoWatkins_EbaySalesApp_Project
{
    partial class LorenzoWatkins_EbaySalesApp_ProjectForm1
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
        // UI controls
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ListBox listBoxOutput;

        private void InitializeComponent()
        {
            textBoxTitle = new TextBox();
            textBoxPrice = new TextBox();
            textBoxCondition = new TextBox();
            buttonCalculate = new Button();
            listBoxOutput = new ListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(20, 20);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Enter item title";
            textBoxTitle.Size = new Size(300, 23);
            textBoxTitle.TabIndex = 0;
            textBoxTitle.GotFocus += textBox_GotFocus;
            textBoxTitle.LostFocus += textBox_LostFocus;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(20, 90);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Enter sale price";
            textBoxPrice.Size = new Size(150, 23);
            textBoxPrice.TabIndex = 2;
            textBoxPrice.GotFocus += textBox_GotFocus;
            textBoxPrice.LostFocus += textBox_LostFocus;
            // 
            // textBoxCondition
            // 
            textBoxCondition.Location = new Point(20, 55);
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.PlaceholderText = "Enter condition (e.g., New, Used)";
            textBoxCondition.Size = new Size(300, 23);
            textBoxCondition.TabIndex = 1;
            textBoxCondition.GotFocus += textBox_GotFocus;
            textBoxCondition.LostFocus += textBox_LostFocus;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(20, 125);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(120, 30);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Calculate Fees";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(20, 170);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(540, 214);
            listBoxOutput.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(245, 129);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(452, 129);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = true;
            // 
            // LorenzoWatkins_EbaySalesApp_ProjectForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxCondition);
            Controls.Add(textBoxPrice);
            Controls.Add(buttonCalculate);
            Controls.Add(listBoxOutput);
            Name = "LorenzoWatkins_EbaySalesApp_ProjectForm1";
            Text = "EbaySalesApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}
