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
            txtCond = new TextBox();
            btnCalc = new Button();
            dgvOutput = new DataGridView();
            lstOutput = new ListBox();
            btnClear = new Button();
            btnQuit = new Button();
            tabMain = new TabControl();
            pgInputs = new TabPage();
            lblProduct = new Label();
            lblCond = new Label();
            lblPrice = new Label();
            pgOutput = new TabPage();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOutput).BeginInit();
            tabMain.SuspendLayout();
            pgInputs.SuspendLayout();
            pgOutput.SuspendLayout();
            SuspendLayout();
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(20, 20);
            txtProduct.Name = "txtProduct";
            txtProduct.PlaceholderText = "Enter product name";
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
            // txtCond
            // 
            txtCond.Location = new Point(20, 67);
            txtCond.Name = "txtCond";
            txtCond.PlaceholderText = "Enter condition (e.g., New, Used)";
            txtCond.Size = new Size(300, 23);
            txtCond.TabIndex = 3;
            txtCond.GotFocus += textBox_GotFocus;
            txtCond.LostFocus += textBox_LostFocus;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(20, 181);
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
            dgvOutput.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvOutput.Location = new Point(20, 20);
            dgvOutput.Name = "dgvOutput";
            dgvOutput.RowHeadersVisible = false;
            dgvOutput.Size = new Size(540, 330);
            dgvOutput.TabIndex = 10;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(20, 170);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(540, 214);
            lstOutput.TabIndex = 9;
            lstOutput.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(245, 188);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(441, 188);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
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
            pgInputs.Controls.Add(lblCond);
            pgInputs.Controls.Add(txtCond);
            pgInputs.Controls.Add(lblPrice);
            pgInputs.Controls.Add(txtPrice);
            pgInputs.Controls.Add(btnCalc);
            pgInputs.Controls.Add(btnClear);
            pgInputs.Controls.Add(btnQuit);
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
            lblProduct.Text = "Product Name:";
            // 
            // lblCond
            // 
            lblCond.AutoSize = true;
            lblCond.Location = new Point(20, 46);
            lblCond.Name = "lblCond";
            lblCond.Size = new Size(63, 15);
            lblCond.TabIndex = 2;
            lblCond.Text = "Condition:";
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
            pgOutput.Controls.Add(lstOutput);
            pgOutput.Location = new Point(4, 24);
            pgOutput.Name = "pgOutput";
            pgOutput.Padding = new Padding(3);
            pgOutput.Size = new Size(572, 352);
            pgOutput.TabIndex = 1;
            pgOutput.Text = "Output";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // LorenzoWatkins_EbaySalesApp_ProjectForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(tabMain);
            Name = "LorenzoWatkins_EbaySalesApp_ProjectForm1";
            Text = "EbaySalesApp";
            ((System.ComponentModel.ISupportInitialize)dgvOutput).EndInit();
            tabMain.ResumeLayout(false);
            pgInputs.ResumeLayout(false);
            pgInputs.PerformLayout();
            pgOutput.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCond;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pgInputs;
        private System.Windows.Forms.TabPage pgOutput;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCond;
        private System.Windows.Forms.Label lblPrice;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
