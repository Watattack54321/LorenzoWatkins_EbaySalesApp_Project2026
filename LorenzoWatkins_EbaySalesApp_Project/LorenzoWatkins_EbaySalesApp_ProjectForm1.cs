using System;
using System.Drawing;
using System.Globalization;
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

        private void Form1_Load(object? sender, EventArgs e)
        {
            rbStandardFee.Checked = true;
        }

        private void feeRateRadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is not RadioButton radioButton || !radioButton.Checked) return;

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

        // When a text box receives focus change its background to highlight
        private void textBox_GotFocus(object? sender, EventArgs e)
        {
            // input stored in variable only for clarity; the control remains the source of truth
            TextBox? focusedBox = sender as TextBox;
            if (focusedBox == null) return;
            // interim variable for color
            Color highlightColor = Color.LightYellow;
            focusedBox.BackColor = highlightColor;
        }

        // When a text box loses focus change color back to default
        private void textBox_LostFocus(object? sender, EventArgs e)
        {
            TextBox? box = sender as TextBox;
            if (box == null) return;
            Color defaultColor = SystemColors.Window;
            box.BackColor = defaultColor;
        }

        // Calculation triggered by button
        private void btnCalc_Click(object? sender, EventArgs e)
        {
            // --- Set object properties from inputs ---
            EbaySales sale = new EbaySales();
            sale.CustomerName = this.txtProduct.Text;

            // Use TryParse instead of try/catch per project guidelines
            if (!decimal.TryParse(this.txtPrice.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal parsedPrice))
            {
                // invalid input: highlight field and return (no MessageBox here)
                txtPrice.BackColor = Color.LightPink;
                txtPrice.Focus();
                return;
            }

            // reset any previous error color
            txtPrice.BackColor = SystemColors.Window;

            sale.SaleAmount = parsedPrice;

            sale.EbayFeeRate = selectedFeeRate;

            // Perform calculations inside the class
            sale.Calculate();

            // --- Output: display all input, interim, and output data in a table (DataGridView) ---
            if (dgvOutput == null) return;
            dgvOutput.Rows.Clear();

            // Inputs and calculated values (read from object properties)
            dgvOutput.Rows.Add("Customer Name", sale.CustomerName, string.Empty);
            dgvOutput.Rows.Add("Sale Amount", sale.SaleAmount.ToString("C", CultureInfo.CurrentCulture), string.Empty);

            dgvOutput.Rows.Add("eBay Fee Rate", sale.EbayFeeRate.ToString("P", CultureInfo.CurrentCulture), string.Empty);
            dgvOutput.Rows.Add("eBay Fee", sale.EbayFee.ToString("C", CultureInfo.CurrentCulture), string.Empty);
            dgvOutput.Rows.Add("Amount Seller Gets", sale.AmountSellerGets.ToString("C", CultureInfo.CurrentCulture), string.Empty);

            // Also show the class-provided summary via ToString()
            dgvOutput.Rows.Add("Summary", sale.ToString(), string.Empty);

            // Keep each calculated design in the list box for comparison.
            lstbox1.Items.Add(sale.ToString());
            tabMain.SelectedTab = pgInputs;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear inputs and output table (use new control names)
            txtProduct.Text = string.Empty;
            txtCond.Text = string.Empty;
            txtPrice.Text = string.Empty;
            if (dgvOutput != null)
            {
                dgvOutput.Rows.Clear();
            }
            lstbox1.Items.Clear();
            // set focus back to title
            txtProduct.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // MessageBox is allowed for exit confirmation per guidelines
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
