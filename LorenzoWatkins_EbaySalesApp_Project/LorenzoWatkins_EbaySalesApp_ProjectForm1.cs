using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LorenzoWatkins_EbaySalesApp_Project
{
    public partial class LorenzoWatkins_EbaySalesApp_ProjectForm1 : Form
    {
        private string fileName = "EbaySalesTransactions.txt";

        public LorenzoWatkins_EbaySalesApp_ProjectForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbElectronics.Checked = true;
        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.LightYellow;
        }

        private void textBox_LostFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = SystemColors.Window;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                MessageBox.Show("Enter a customer name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduct.Focus();
                return;
            }

            decimal saleAmount;
            if (!decimal.TryParse(txtPrice.Text, out saleAmount) || saleAmount <= 0)
            {
                MessageBox.Show("Enter a sale price greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.BackColor = Color.LightPink;
                txtPrice.Focus();
                return;
            }

            txtPrice.BackColor = SystemColors.Window;

            string category;
            if (rbClothing.Checked)
            {
                category = "Clothing";
            }
            else if (rbCollectibles.Checked)
            {
                category = "Collectibles";
            }
            else
            {
                category = "Electronics";
            }

            EbaySales sale = new EbaySales(txtProduct.Text, category, saleAmount);

            switch (sale.Category)
            {
                case "Clothing":
                    sale.EbayFeeRate = 0.119m;
                    break;
                case "Collectibles":
                    sale.EbayFeeRate = 0.149m;
                    break;
                default:
                    sale.EbayFeeRate = 0.129m;
                    break;
            }

            sale.Calculate();
            WriteTransaction(sale);
            tabMain.SelectedTab = pgOutput;
        }

        private void WriteTransaction(EbaySales sale)
        {
            StreamWriter outputFile;
            try
            {
                outputFile = File.AppendText(fileName);
                try
                {
                    outputFile.WriteLine(DateTime.Now.ToString());
                    outputFile.WriteLine("----- New Transaction -----");
                    outputFile.WriteLine("Customer: " + sale.CustomerName);
                    outputFile.WriteLine("Category: " + sale.Category);
                    outputFile.WriteLine("Sale Amount: " + sale.SaleAmount.ToString("C"));
                    outputFile.WriteLine("eBay Fee Rate: " + sale.EbayFeeRate.ToString("P"));
                    outputFile.WriteLine("eBay Fee: " + sale.EbayFee.ToString("C"));
                    outputFile.WriteLine("Seller Gets: " + sale.AmountSellerGets.ToString("C"));
                    outputFile.WriteLine();
                }
                finally
                {
                    outputFile.Close();
                }

                lstbox1.Items.Add(sale.ToString());
            }
            catch (IOException)
            {
                MessageBox.Show("The transaction could not be written to the file.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to write the transaction file.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProduct.Text = string.Empty;
            txtPrice.Text = string.Empty;
            lstbox1.Items.Clear();
            txtProduct.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
