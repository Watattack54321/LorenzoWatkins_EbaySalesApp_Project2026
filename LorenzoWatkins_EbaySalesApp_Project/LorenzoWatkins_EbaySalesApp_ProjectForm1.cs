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
            // --- Variables declared at the beginning of the procedure ---
            string itemTitle = string.Empty; // input: item title (string)
            string itemCondition = string.Empty; // input: condition (string)
            decimal salePrice = 0m; // input: price (numeric)

            // Read inputs into variables (all input stored in variables)
            itemTitle = this.textBoxTitle.Text;
            itemCondition = this.textBoxCondition.Text;

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

            salePrice = parsedPrice; // store parsed numeric input in variable

            // Create an EbayItem object (requirement: create object in the form code)
            EbayItem item = new EbayItem(itemTitle, itemCondition, salePrice);

            // Use the class's methods and properties for all interim calculations
            decimal ebayCommissionRate = item.CommissionRate;
            decimal salesTaxRate = item.SalesTaxRate;
            decimal commissionAmount = item.GetCommissionAmount();
            decimal salesTaxAmount = item.GetSalesTaxAmount();
            decimal netRevenue = item.GetNetRevenue();
            decimal promoDiscountRate = item.PromoDiscountRate;
            decimal promoDiscountAmount = item.GetPromoDiscountAmount();
            decimal revenueAfterDiscount = item.GetRevenueAfterDiscount();

            // --- Output: display all input, interim, and output data in ListBox ---
            listBoxOutput.Items.Clear();

            // Inputs
            listBoxOutput.Items.Add("Item Title: " + itemTitle);
            listBoxOutput.Items.Add("Condition: " + itemCondition);

            // Numeric data formatted appropriately
            listBoxOutput.Items.Add("Sale Price: " + salePrice.ToString("C", CultureInfo.CurrentCulture)); // Currency
            listBoxOutput.Items.Add("eBay Commission (rate): " + ebayCommissionRate.ToString("P", CultureInfo.CurrentCulture)); // Percent
            listBoxOutput.Items.Add("eBay Commission (amount): " + commissionAmount.ToString("C", CultureInfo.CurrentCulture)); // Currency
            listBoxOutput.Items.Add("Sales Tax (rate): " + salesTaxRate.ToString("P", CultureInfo.CurrentCulture)); // Percent
            listBoxOutput.Items.Add("Sales Tax (amount): " + salesTaxAmount.ToString("C", CultureInfo.CurrentCulture)); // Currency
            listBoxOutput.Items.Add("Net Revenue: " + netRevenue.ToString("C", CultureInfo.CurrentCulture)); // Currency
            listBoxOutput.Items.Add("Promotional Discount (rate): " + promoDiscountRate.ToString("P", CultureInfo.CurrentCulture)); // Percent
            listBoxOutput.Items.Add("Promotional Discount (amount): " + promoDiscountAmount.ToString("C", CultureInfo.CurrentCulture)); // Currency
            listBoxOutput.Items.Add("Revenue After Discount: " + revenueAfterDiscount.ToString("C", CultureInfo.CurrentCulture)); // Currency

            // Also show a numeric as a number formatted (Number format)
            listBoxOutput.Items.Add("Commission amount (number format): " + commissionAmount.ToString("N2", CultureInfo.CurrentCulture));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
