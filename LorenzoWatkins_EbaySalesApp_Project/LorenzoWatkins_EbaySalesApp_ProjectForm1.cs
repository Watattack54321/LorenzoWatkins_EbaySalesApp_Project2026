using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LorenzoWatkins_EbaySalesApp_Project
{
    public partial class LorenzoWatkins_EbaySalesApp_ProjectForm1 : Form
    {
        private string fileName = "EbaySalesTransactions.txt";
        private string configurationFileName = "EbaySalesFees.txt";
        private string selectedCategory = EbaySales.ELECTRONICS;
        private decimal electronicsFee = 0.12m;
        private decimal clothingFee = 0.10m;
        private decimal collectiblesFee = 0.08m;

        public LorenzoWatkins_EbaySalesApp_ProjectForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadConfigurationFile();
            rdoElectronics.Checked = true;
        }

        private void ReadConfigurationFile()
        {
            if (!File.Exists(configurationFileName))
            {
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.Title = "Open eBay Fee Configuration File";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    configurationFileName = openFileDialog1.FileName;
                }
            }

            try
            {
                StreamReader inputFile = File.OpenText(configurationFileName);
                try
                {
                    int lineNumber = 0;
                    do
                    {
                        string configurationLine = inputFile.ReadLine() ?? string.Empty;
                        decimal fee;
                        if (!decimal.TryParse(configurationLine, out fee))
                        {
                            throw new FormatException("The fee configuration file contains an invalid value.");
                        }

                        if (lineNumber == 0)
                        {
                            electronicsFee = fee;
                        }
                        else if (lineNumber == 1)
                        {
                            clothingFee = fee;
                        }
                        else
                        {
                            collectiblesFee = fee;
                        }

                        lineNumber++;
                    }
                    while (lineNumber < 3);
                }
                finally
                {
                    inputFile.Close();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The fee configuration file could not be found. Default fee values will be used.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("The fee configuration file could not be read. Default fee values will be used.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("The fee configuration file contains invalid data. Default fee values will be used.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to read the fee configuration file. Default fee values will be used.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdoElectronics_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoElectronics.Checked)
            {
                selectedCategory = EbaySales.ELECTRONICS;
            }
        }

        private void rdoClothing_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoClothing.Checked)
            {
                selectedCategory = EbaySales.CLOTHING;
            }
        }

        private void rdoCollectibles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCollectibles.Checked)
            {
                selectedCategory = EbaySales.COLLECTIBLES;
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


            // you should not clear the list box except on a clear
            if (saleAmountIsValid && customerNameIsValid)
            {
                txtPrice.BackColor = SystemColors.Window;

                EbaySales sale = new EbaySales(txtProduct.Text, selectedCategory, saleAmount);

                sale.SetFeeRates(electronicsFee, clothingFee, collectiblesFee);
                sale.SetFeeRate();
                sale.Calculate();
                WriteTransaction(sale);
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
                    outputFile.WriteLine("Date and Time: " + DateTime.Now.ToString());
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

                lstOut.Items.Add("Customer: " + sale.CustomerName);
                lstOut.Items.Add("Category: " + sale.Category);
                lstOut.Items.Add("Sale Amount: " + sale.SaleAmount.ToString("C"));
                lstOut.Items.Add("eBay Fee Rate: " + sale.EbayFeeRate.ToString("P"));
                lstOut.Items.Add("eBay Fee: " + sale.EbayFee.ToString("C"));
                lstOut.Items.Add("Seller Gets: " + sale.AmountSellerGets.ToString("C"));
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