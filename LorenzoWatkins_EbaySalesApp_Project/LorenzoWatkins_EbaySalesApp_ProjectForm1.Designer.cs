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
        private void InitializeComponent()
        {
            txtProduct = new TextBox();
            txtPrice = new TextBox();
            btnCalc = new Button();
            dgvOutput = new DataGridView();
            dgvColLabel = new DataGridViewTextBoxColumn();
            dgvColValue = new DataGridViewTextBoxColumn();
            dgvColExtra = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            btnQuit = new Button();
            tabMain = new TabControl();
            pgInputs = new TabPage();
            lblProduct = new Label();
            lblPrice = new Label();
            grpFeeRate = new GroupBox();
            rbStandardFee = new RadioButton();
            rbReducedFee = new RadioButton();
            rbPremiumFee = new RadioButton();
            lstErrors = new ListBox();
            pgOutput = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvOutput).BeginInit();
            tabMain.SuspendLayout();
            pgInputs.SuspendLayout();
            grpFeeRate.SuspendLayout();
            pgOutput.SuspendLayout();
            SuspendLayout();
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(20, 20);
            txtProduct.Name = "txtProduct";
            txtProduct.PlaceholderText = "Enter customer name";
            txtProduct.Size = new Size(300, 23);
            txtProduct.TabIndex = 1;
            txtProduct.GotFocus += textBox_GotFocus;
            txtProduct.LostFocus += textBox_LostFocus;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(20, 111);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Enter sale price";
            txtPrice.Size = new Size(150, 23);
            txtPrice.TabIndex = 5;
            txtPrice.GotFocus += textBox_GotFocus;
            txtPrice.LostFocus += textBox_LostFocus;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(20, 160);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(120, 30);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calculate Fees";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // dgvOutput
            // 
            dgvOutput.AllowUserToAddRows = false;
            dgvOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutput.Columns.AddRange(new DataGridViewColumn[] { dgvColLabel, dgvColValue, dgvColExtra });
            dgvOutput.Location = new Point(20, 20);
            dgvOutput.Name = "dgvOutput";
            dgvOutput.RowHeadersVisible = false;
            dgvOutput.Size = new Size(540, 330);
            dgvOutput.TabIndex = 10;
            // 
            // dgvColLabel
            // 
            dgvColLabel.Name = "dgvColLabel";
            // 
            // dgvColValue
            // 
            dgvColValue.Name = "dgvColValue";
            // 
            // dgvColExtra
            // 
            dgvColExtra.Name = "dgvColExtra";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(243, 160);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 30);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(440, 160);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(78, 30);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // grpFeeRate
            // 
            grpFeeRate.Controls.Add(rbPremiumFee);
            grpFeeRate.Controls.Add(rbReducedFee);
            grpFeeRate.Controls.Add(rbStandardFee);
            grpFeeRate.Location = new Point(340, 10);
            grpFeeRate.Name = "grpFeeRate";
            grpFeeRate.Size = new Size(200, 125);
            grpFeeRate.TabIndex = 12;
            grpFeeRate.TabStop = false;
            grpFeeRate.Text = "eBay Fee Rate";
            // 
            // rbStandardFee
            // 
            rbStandardFee.AutoSize = true;
            rbStandardFee.Location = new Point(15, 25);
            rbStandardFee.Name = "rbStandardFee";
            rbStandardFee.Size = new Size(140, 19);
            rbStandardFee.TabIndex = 13;
            rbStandardFee.TabStop = true;
            rbStandardFee.Text = "Standard (12.9%)";
            rbStandardFee.UseVisualStyleBackColor = true;
            rbStandardFee.CheckedChanged += feeRateRadioButton_CheckedChanged;
            // 
            // rbReducedFee
            // 
            rbReducedFee.AutoSize = true;
            rbReducedFee.Location = new Point(15, 55);
            rbReducedFee.Name = "rbReducedFee";
            rbReducedFee.Size = new Size(130, 19);
            rbReducedFee.TabIndex = 14;
            rbReducedFee.Text = "Reduced (11.9%)";
            rbReducedFee.UseVisualStyleBackColor = true;
            rbReducedFee.CheckedChanged += feeRateRadioButton_CheckedChanged;
            // 
            // rbPremiumFee
            // 
            rbPremiumFee.AutoSize = true;
            rbPremiumFee.Location = new Point(15, 85);
            rbPremiumFee.Name = "rbPremiumFee";
            rbPremiumFee.Size = new Size(130, 19);
            rbPremiumFee.TabIndex = 15;
            rbPremiumFee.Text = "Premium (14.9%)";
            rbPremiumFee.UseVisualStyleBackColor = true;
            rbPremiumFee.CheckedChanged += feeRateRadioButton_CheckedChanged;
            // 
            // lstErrors
            // 
            lstErrors.FormattingEnabled = true;
            lstErrors.ItemHeight = 15;
            lstErrors.Location = new Point(340, 150);
            lstErrors.Name = "lstErrors";
            lstErrors.Size = new Size(200, 79);
            lstErrors.TabIndex = 16;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(pgInputs);
            tabMain.Controls.Add(pgOutput);
            tabMain.Location = new Point(10, 10);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(580, 380);
            tabMain.TabIndex = 11;
            // 
            // pgInputs
            // 
            pgInputs.Controls.Add(lblProduct);
            pgInputs.Controls.Add(txtProduct);
            pgInputs.Controls.Add(lblPrice);
            pgInputs.Controls.Add(txtPrice);
            pgInputs.Controls.Add(btnCalc);
            pgInputs.Controls.Add(btnClear);
            pgInputs.Controls.Add(btnQuit);
            pgInputs.Controls.Add(grpFeeRate);
            pgInputs.Controls.Add(lstErrors);
            pgInputs.Location = new Point(4, 24);
            pgInputs.Name = "pgInputs";
            pgInputs.Padding = new Padding(3);
            pgInputs.Size = new Size(572, 352);
            pgInputs.TabIndex = 0;
            pgInputs.Text = "Inputs";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(20, 2);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(87, 15);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Customer Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 93);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // pgOutput
            // 
            pgOutput.Controls.Add(dgvOutput);
            pgOutput.Location = new Point(4, 24);
            pgOutput.Name = "pgOutput";
            pgOutput.Padding = new Padding(3);
            pgOutput.Size = new Size(572, 352);
            pgOutput.TabIndex = 1;
            pgOutput.Text = "Output";
            // 
            // LorenzoWatkins_EbaySalesApp_ProjectForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(tabMain);
            Name = "LorenzoWatkins_EbaySalesApp_ProjectForm1";
            Text = "EbaySalesApp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOutput).EndInit();
            tabMain.ResumeLayout(false);
            pgInputs.ResumeLayout(false);
            pgInputs.PerformLayout();
            grpFeeRate.ResumeLayout(false);
            grpFeeRate.PerformLayout();
            pgOutput.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pgInputs;
        private System.Windows.Forms.TabPage pgOutput;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox grpFeeRate;
        private System.Windows.Forms.RadioButton rbStandardFee;
        private System.Windows.Forms.RadioButton rbReducedFee;
        private System.Windows.Forms.RadioButton rbPremiumFee;
        private System.Windows.Forms.ListBox lstErrors;
        private DataGridViewTextBoxColumn dgvColLabel;
        private DataGridViewTextBoxColumn dgvColValue;
        private DataGridViewTextBoxColumn dgvColExtra;
    }
}
