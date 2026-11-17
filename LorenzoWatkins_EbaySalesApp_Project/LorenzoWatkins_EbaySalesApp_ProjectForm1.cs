using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LorenzoWatkins_EbaySalesApp_Project
{
    public partial class LorenzoWatkins_EbaySalesApp_ProjectForm1 : Form
    {
        private const string ELECTRONICS = "Electronics";
        private const string CLOTHING = "Clothing";
        private const string COLLECTIBLES = "Collectibles";
        private const decimal ELECTRONICS_FEE = 0.12m;
        private const decimal CLOTHING_FEE = 0.10m;
        private const decimal COLLECTIBLES_FEE = 0.08m;
        private string fileName = "EbaySalesTransactions.txt";
        private string selectedCategory = ELECTRONICS;

        public LorenzoWatkins_EbaySalesApp_ProjectForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoElectronics.Checked = true;
        }

        private void rdoElectronics_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoElectronics.Checked)
            {
                selectedCategory = ELECTRONICS;
            }
        }

        private void rdoClothing_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoClothing.Checked)
            {
                selectedCategory = CLOTHING;
            }
        }

        private void rdoCollectibles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCollectibles.Checked)
            {
                selectedCategory = COLLECTIBLES;
            }
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
            decimal saleAmount;
            bool saleAmountIsValid = decimal.TryParse(txtPrice.Text, out saleAmount) && saleAmount > 0m;
            bool customerNameIsValid = !string.IsNullOrWhiteSpace(txtProduct.Text);

            lstOut.Items.Clear();

            if (saleAmountIsValid && customerNameIsValid)
            {
                txtPrice.BackColor = SystemColors.Window;

                EbaySales sale = new EbaySales(txtProduct.Text, selectedCategory, saleAmount);

                switch (sale.Category)
                {
                    case ELECTRONICS:
                        sale.EbayFeeRate = ELECTRONICS_FEE;
                        break;
                    case CLOTHING:
                        sale.EbayFeeRate = CLOTHING_FEE;
                        break;
                    case COLLECTIBLES:
                        sale.EbayFeeRate = COLLECTIBLES_FEE;
                        break;
                    default:
                        sale.EbayFeeRate = 0m;
                        break;
                }

                sale.Calculate();
                WriteTransaction(sale);
                lstOut.Items.Add("Category: " + sale.Category);
                lstOut.Items.Add("eBay Store Fee: " + sale.EbayFeeRate.ToString("P"));
                tabMain.SelectedTab = pgOutput;
            }
            else
            {
                if (!customerNameIsValid)
                {
                    lstOut.Items.Add("Error: Enter a customer name.");
                }

                if (!saleAmountIsValid)
                {
                    lstOut.Items.Add("Error: Enter a sale price greater than zero.");
                }
            }
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

                lstOut.Items.Add(sale.ToString());
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
            lstOut.Items.Clear();
            rdoElectronics.Checked = true;
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