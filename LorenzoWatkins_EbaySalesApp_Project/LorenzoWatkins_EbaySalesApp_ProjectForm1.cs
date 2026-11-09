using System;
using System.Drawing;
using System.Windows.Forms;

namespace LorenzoWatkins_EbaySalesApp_Project
{
    public partial class LorenzoWatkins_EbaySalesApp_ProjectForm1 : Form
    {
        private const int StandardFeeChoice = 1;
        private const int ReducedFeeChoice = 2;
        private const int PremiumFeeChoice = 3;

        private int selectedFeeChoice;
        private decimal selectedFeeRate;

        public LorenzoWatkins_EbaySalesApp_ProjectForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbStandardFee.Checked = true;
        }

        private void feeRateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton radioButton) || !radioButton.Checked) return;

            if (radioButton == rbStandardFee)
            {
                SetFeeChoice(StandardFeeChoice);
            }
            else if (radioButton == rbReducedFee)
            {
                SetFeeChoice(ReducedFeeChoice);
            }
            else if (radioButton == rbPremiumFee)
            {
                SetFeeChoice(PremiumFeeChoice);
            }
        }

        private void SetFeeChoice(int feeChoice)
        {
            selectedFeeChoice = feeChoice;

            switch (selectedFeeChoice)
            {
                case StandardFeeChoice:
                    selectedFeeRate = 0.129m;
                    break;
                case ReducedFeeChoice:
                    selectedFeeRate = 0.119m;
                    break;
                case PremiumFeeChoice:
                    selectedFeeRate = 0.149m;
                    break;
                default:
                    selectedFeeRate = 0.129m;
                    break;
            }
        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            if (sender is TextBox focusedBox)
            {
                focusedBox.BackColor = Color.LightYellow;
            }
        }

        private void textBox_LostFocus(object sender, EventArgs e)
        {
            if (sender is TextBox box)
            {
                box.BackColor = SystemColors.Window;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal parsedPrice;
            if (!decimal.TryParse(txtPrice.Text, out parsedPrice))
            {
                txtPrice.BackColor = Color.LightPink;
                txtPrice.Focus();
                return;
            }

            txtPrice.BackColor = SystemColors.Window;

            EbaySales sale = new EbaySales(txtProduct.Text, parsedPrice, selectedFeeRate);
            dgvOutput.Rows.Clear();

            dgvOutput.Rows.Add("Customer Name", sale.CustomerName);
            dgvOutput.Rows.Add("Sale Amount", sale.SaleAmount.ToString("C"));
            dgvOutput.Rows.Add("eBay Fee Rate", sale.EbayFeeRate.ToString("P"));
            dgvOutput.Rows.Add("eBay Fee", sale.EbayFee.ToString("C"));
            dgvOutput.Rows.Add("Amount Seller Gets", sale.AmountSellerGets.ToString("C"));
            dgvOutput.Rows.Add("Summary", sale.ToString(), string.Empty);
            tabMain.SelectedTab = pgOutput;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProduct.Text = string.Empty;
            txtPrice.Text = string.Empty;
            dgvOutput.Rows.Clear();
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
