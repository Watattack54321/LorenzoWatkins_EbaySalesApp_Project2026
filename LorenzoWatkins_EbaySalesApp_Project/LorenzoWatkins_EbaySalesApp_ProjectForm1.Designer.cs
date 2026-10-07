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
            components = new System.ComponentModel.Container();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(20, 20);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(300, 23);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.PlaceholderText = "Enter item title";
            this.textBoxTitle.GotFocus += new System.EventHandler(this.textBox_GotFocus);
            this.textBoxTitle.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(20, 55);
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(300, 23);
            this.textBoxCondition.TabIndex = 1;
            this.textBoxCondition.PlaceholderText = "Enter condition (e.g., New, Used)";
            this.textBoxCondition.GotFocus += new System.EventHandler(this.textBox_GotFocus);
            this.textBoxCondition.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(20, 90);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(150, 23);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.PlaceholderText = "Enter sale price";
            this.textBoxPrice.GotFocus += new System.EventHandler(this.textBox_GotFocus);
            this.textBoxPrice.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(20, 125);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(120, 30);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate Fees";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 15;
            this.listBoxOutput.Location = new System.Drawing.Point(20, 170);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(540, 214);
            this.listBoxOutput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(600, 400);
            Controls.Add(this.textBoxTitle);
            Controls.Add(this.textBoxCondition);
            Controls.Add(this.textBoxPrice);
            Controls.Add(this.buttonCalculate);
            Controls.Add(this.listBoxOutput);
            Name = "Form1";
            Text = "EbaySalesApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
