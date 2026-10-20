using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LorenzoWatkins_EbaySalesApp_Project
{
    public partial class LorenzoWatkins_EbaySalesApp_ProjectForm1 : Form
    {
        public LorenzoWatkins_EbaySalesApp_ProjectForm1()
        {
            InitializeComponent();
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
            // --- Set object properties from inputs (no local interim variables for results) ---
            // Create an EbayItem object and set its properties from the form (use new control names)
            EbayItem item = new EbayItem();
            item.ProductName = this.txtProduct.Text;
            item.Condition = this.txtCond.Text;

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

            item.SalePrice = parsedPrice; // set numeric input directly on the object

            // Perform calculations inside the class
            item.Calculate();

            // --- Output: display all input, interim, and output data in a table (DataGridView) ---
            if (dgvOutput != null)
            {
                dgvOutput.Rows.Clear();
            }

            // Inputs (read from object properties)
            dgvOutput.Rows.Add("Product Name", item.ProductName, string.Empty);
            dgvOutput.Rows.Add("Condition", item.Condition, string.Empty);

            // Numeric data formatted appropriately
            dgvOutput.Rows.Add("Sale Price", item.SalePrice.ToString("C", CultureInfo.CurrentCulture), string.Empty); // Currency
            dgvOutput.Rows.Add("eBay Commission (rate)", item.CommissionRate.ToString("P", CultureInfo.CurrentCulture), string.Empty); // Percent
            dgvOutput.Rows.Add("eBay Commission (amount)", item.CommissionAmount.ToString("C", CultureInfo.CurrentCulture), string.Empty); // Currency
            dgvOutput.Rows.Add("Sales Tax (rate)", item.SalesTaxRate.ToString("P", CultureInfo.CurrentCulture), string.Empty); // Percent
            dgvOutput.Rows.Add("Sales Tax (amount)", item.SalesTaxAmount.ToString("C", CultureInfo.CurrentCulture), string.Empty); // Currency
            dgvOutput.Rows.Add("Customer Price", item.CustomerPrice.ToString("C", CultureInfo.CurrentCulture), string.Empty);
            dgvOutput.Rows.Add("Net Revenue", item.NetRevenue.ToString("C", CultureInfo.CurrentCulture), string.Empty); // Currency
            dgvOutput.Rows.Add("Promotional Discount (rate)", item.PromoDiscountRate.ToString("P", CultureInfo.CurrentCulture), string.Empty); // Percent
            dgvOutput.Rows.Add("Promotional Discount (amount)", item.PromoDiscountAmount.ToString("C", CultureInfo.CurrentCulture), string.Empty); // Currency
            dgvOutput.Rows.Add("Revenue After Discount", item.RevenueAfterDiscount.ToString("C", CultureInfo.CurrentCulture), string.Empty); // Currency

            // Also show the class-provided summary via ToString()
            dgvOutput.Rows.Add("Summary", item.ToString(), string.Empty);

            // Also show a numeric as a number formatted (Number format)
            dgvOutput.Rows.Add("Commission amount (number format)", item.CommissionAmount.ToString("N2", CultureInfo.CurrentCulture), string.Empty);

            // Keep each calculated design in the list box for comparison.
            lstbox1.Items.Add(item.ToString());
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
