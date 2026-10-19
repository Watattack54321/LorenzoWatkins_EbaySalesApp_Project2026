using System;
using System.Globalization;

namespace LorenzoWatkins_EbaySalesApp_Project
{
    // Class representing an eBay item and calculation helpers
    public class EbayItem
    {
        // Properties for data needed for calculations
        public string ProductName { get; set; }
        public string Condition { get; set; }
        public decimal SalePrice { get; set; }

        // Rates used in calculations
        public decimal CommissionRate { get; set; }
        public decimal SalesTaxRate { get; set; }
        public decimal PromoDiscountRate { get; set; }

        // Default constructor
        public EbayItem()
        {
            ProductName = string.Empty;
            Condition = string.Empty;
            SalePrice = 0m;

            // sensible defaults
            CommissionRate = 0.129m; // 12.9%
            SalesTaxRate = 0.07m; // 7%
            PromoDiscountRate = 0m;
        }

        // Constructor with parameters
        public EbayItem(string productName, string condition, decimal salePrice)
        {
            ProductName = productName;
            Condition = condition;
            SalePrice = salePrice;

            CommissionRate = 0.129m;
            SalesTaxRate = 0.07m;

            // If item is new, apply a default promo discount rate
            if (!string.IsNullOrWhiteSpace(condition) && condition.Trim().Equals("New", StringComparison.OrdinalIgnoreCase))
            {
                PromoDiscountRate = 0.05m;
            }
            else
            {
                PromoDiscountRate = 0m;
            }
        }

        // Calculated values stored as properties after Calculate() is called
        public decimal CommissionAmount { get; private set; }
        public decimal SalesTaxAmount { get; private set; }
        public decimal NetRevenue { get; private set; }
        public decimal PromoDiscountAmount { get; private set; }
        public decimal RevenueAfterDiscount { get; private set; }

        // Perform all calculations and populate the calculated properties
        public void Calculate()
        {
            // Ensure promo rate matches condition
            if (!string.IsNullOrWhiteSpace(Condition) && Condition.Trim().Equals("New", StringComparison.OrdinalIgnoreCase))
            {
                PromoDiscountRate = 0.05m;
            }
            else
            {
                PromoDiscountRate = 0m;
            }

            CommissionAmount = SalePrice * CommissionRate;
            SalesTaxAmount = SalePrice * SalesTaxRate;
            NetRevenue = SalePrice - CommissionAmount - SalesTaxAmount;
            PromoDiscountAmount = SalePrice * PromoDiscountRate;
            RevenueAfterDiscount = NetRevenue - PromoDiscountAmount;
        }

        // Backwards-compatible helper methods (optional)
        public decimal GetCommissionAmount() => CommissionAmount == 0m ? SalePrice * CommissionRate : CommissionAmount;
        public decimal GetSalesTaxAmount() => SalesTaxAmount == 0m ? SalePrice * SalesTaxRate : SalesTaxAmount;
        public decimal GetNetRevenue() => NetRevenue == 0m ? SalePrice - GetCommissionAmount() - GetSalesTaxAmount() : NetRevenue;
        public decimal GetPromoDiscountAmount() => PromoDiscountAmount == 0m ? SalePrice * PromoDiscountRate : PromoDiscountAmount;
        public decimal GetRevenueAfterDiscount() => RevenueAfterDiscount == 0m ? GetNetRevenue() - GetPromoDiscountAmount() : RevenueAfterDiscount;

        // Provide a helpful string representation for the EbaySalesApp
        public override string ToString()
        {
            return $"{ProductName} | Condition: {Condition} | Price: {SalePrice.ToString("C", CultureInfo.CurrentCulture)} | Revenue After Discount: {RevenueAfterDiscount.ToString("C", CultureInfo.CurrentCulture)}";
        }
    }
}
