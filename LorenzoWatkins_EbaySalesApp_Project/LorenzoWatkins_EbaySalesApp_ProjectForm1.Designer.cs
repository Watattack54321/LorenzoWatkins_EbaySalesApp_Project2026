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
            lstOut = new ListBox();
            btnClear = new Button();
            btnQuit = new Button();
            tabMain = new TabControl();
            pgInputs = new TabPage();
            lblProduct = new Label();
            lblPrice = new Label();
            grpCategory = new GroupBox();
            rdoCollectibles = new RadioButton();
            rdoClothing = new RadioButton();
            rdoElectronics = new RadioButton();
            pgOutput = new TabPage();
            tabMain.SuspendLayout();
            pgInputs.SuspendLayout();
            grpCategory.SuspendLayout();
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
            txtPrice.Location = new Point(20, 67);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Enter sale price";
            txtPrice.Size = new Size(150, 23);
            txtPrice.TabIndex = 3;
            txtPrice.GotFocus += textBox_GotFocus;
            txtPrice.LostFocus += textBox_LostFocus;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(20, 160);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(120, 30);
            btnCalc.TabIndex = 4;
            btnCalc.Text = "Calculate Fees";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(12, 12);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(540, 319);
            lstOut.TabIndex = 10;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(243, 160);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 30);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(440, 160);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(78, 30);
            btnQuit.TabIndex = 6;
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
            pgInputs.Controls.Add(lblPrice);
            pgInputs.Controls.Add(txtPrice);
            pgInputs.Controls.Add(btnCalc);
            pgInputs.Controls.Add(btnClear);
            pgInputs.Controls.Add(btnQuit);
            pgInputs.Controls.Add(grpCategory);
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
            lblProduct.Size = new Size(97, 15);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Customer Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 46);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // grpCategory
            // 
            grpCategory.Controls.Add(rdoCollectibles);
            grpCategory.Controls.Add(rdoClothing);
            grpCategory.Controls.Add(rdoElectronics);
            grpCategory.Location = new Point(340, 10);
            grpCategory.Name = "grpCategory";
            grpCategory.Size = new Size(200, 125);
            grpCategory.TabIndex = 12;
            grpCategory.TabStop = false;
            grpCategory.Text = "Product Category";
            // 
            // rdoCollectibles
            // 
            rdoCollectibles.AutoSize = true;
            rdoCollectibles.Location = new Point(15, 85);
            rdoCollectibles.Name = "rdoCollectibles";
            rdoCollectibles.Size = new Size(86, 19);
            rdoCollectibles.TabIndex = 15;
            rdoCollectibles.Text = "Collectibles";
            rdoCollectibles.UseVisualStyleBackColor = true;
            rdoCollectibles.CheckedChanged += rdoCollectibles_CheckedChanged;
            // 
            // rdoClothing
            // 
            rdoClothing.AutoSize = true;
            rdoClothing.Location = new Point(15, 55);
            rdoClothing.Name = "rdoClothing";
            rdoClothing.Size = new Size(72, 19);
            rdoClothing.TabIndex = 14;
            rdoClothing.Text = "Clothing";
            rdoClothing.UseVisualStyleBackColor = true;
            rdoClothing.CheckedChanged += rdoClothing_CheckedChanged;
            // 
            // rdoElectronics
            // 
            rdoElectronics.AutoSize = true;
            rdoElectronics.Location = new Point(15, 25);
            rdoElectronics.Name = "rdoElectronics";
            rdoElectronics.Size = new Size(81, 19);
            rdoElectronics.TabIndex = 13;
            rdoElectronics.TabStop = true;
            rdoElectronics.Text = "Electronics";
            rdoElectronics.UseVisualStyleBackColor = true;
            rdoElectronics.CheckedChanged += rdoElectronics_CheckedChanged;
            // 
            // pgOutput
            // 
            pgOutput.Controls.Add(lstOut);
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
            tabMain.ResumeLayout(false);
            pgInputs.ResumeLayout(false);
            pgInputs.PerformLayout();
            grpCategory.ResumeLayout(false);
            grpCategory.PerformLayout();
            pgOutput.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pgInputs;
        private System.Windows.Forms.TabPage pgOutput;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.RadioButton rdoElectronics;
        private System.Windows.Forms.RadioButton rdoClothing;
        private System.Windows.Forms.RadioButton rdoCollectibles;
    }
}