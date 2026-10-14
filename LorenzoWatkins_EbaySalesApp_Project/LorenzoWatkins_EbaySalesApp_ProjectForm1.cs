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
        private void buttonCalculate_Click(object? sender, EventArgs e)
        {
            // --- Set object properties from inputs (no local interim variables for results) ---
            // Create an EbayItem object and set its properties from the form
            EbayItem item = new EbayItem();
            item.Title = this.textBoxTitle.Text;
            item.Condition = this.textBoxCondition.Text;

            // Use Parse to convert the numeric string to a decimal (requirement)
            decimal parsedPrice;
            try
            {
                parsedPrice = decimal.Parse(this.textBoxPrice.Text, CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid numeric sale price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            item.SalePrice = parsedPrice; // set numeric input directly on the object

            // Perform calculations inside the class
            item.Calculate();

            // Read results from object properties
            decimal ebayCommissionRate = item.CommissionRate;
            decimal salesTaxRate = item.SalesTaxRate;
            decimal commissionAmount = item.CommissionAmount;
            decimal salesTaxAmount = item.SalesTaxAmount;
            decimal netRevenue = item.NetRevenue;
            decimal promoDiscountRate = item.PromoDiscountRate;
            decimal promoDiscountAmount = item.PromoDiscountAmount;
            decimal revenueAfterDiscount = item.RevenueAfterDiscount;

            // --- Output: display all input, interim, and output data in ListBox ---
            listBoxOutput.Items.Clear();

            // Inputs (read from object properties)
            listBoxOutput.Items.Add("Item Title: " + item.Title);
            listBoxOutput.Items.Add("Condition: " + item.Condition);

            // Numeric data formatted appropriately
            listBoxOutput.Items.Add("Sale Price: " + item.SalePrice.ToString("C", CultureInfo.CurrentCulture)); // Currency
            listBoxOutput.Items.Add("eBay Commission (rate): " + ebayCommissionRate.ToString("P", CultureInfo.CurrentCulture)); // Percent
            listBoxOutput.Items.Add("eBay Commission (amount): " + commissionAmount.ToString("C", CultureInfo.CurrentCulture)); // Currency
            listBoxOutput.Items.Add("Sales Tax (rate): " + salesTaxRate.ToString("P", CultureInfo.CurrentCulture)); // Percent
            listBoxOutput.Items.Add("Sales Tax (amount): " + salesTaxAmount.ToString("C", CultureInfo.CurrentCulture)); // Currency
            listBoxOutput.Items.Add("Net Revenue: " + netRevenue.ToString("C", CultureInfo.CurrentCulture)); // Currency
            listBoxOutput.Items.Add("Promotional Discount (rate): " + promoDiscountRate.ToString("P", CultureInfo.CurrentCulture)); // Percent
            listBoxOutput.Items.Add("Promotional Discount (amount): " + promoDiscountAmount.ToString("C", CultureInfo.CurrentCulture)); // Currency
            listBoxOutput.Items.Add("Revenue After Discount: " + revenueAfterDiscount.ToString("C", CultureInfo.CurrentCulture)); // Currency

            // Also show the class-provided summary via ToString()
            listBoxOutput.Items.Add("Summary: " + item.ToString());

            // Also show a numeric as a number formatted (Number format)
            listBoxOutput.Items.Add("Commission amount (number format): " + commissionAmount.ToString("N2", CultureInfo.CurrentCulture));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
