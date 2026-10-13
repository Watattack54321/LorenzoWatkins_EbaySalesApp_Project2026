using System;

namespace LorenzoWatkins_EbaySalesApp_Project
{
    // Class representing an eBay item and calculation helpers
    public class EbayItem
    {
        // Properties for data needed for calculations
        public string Title { get; set; }
        public string Condition { get; set; }
        public decimal SalePrice { get; set; }

        // Rates used in calculations
        public decimal CommissionRate { get; set; }
        public decimal SalesTaxRate { get; set; }
        public decimal PromoDiscountRate { get; set; }

        // Default constructor
        public EbayItem()
        {
            Title = string.Empty;
            Condition = string.Empty;
            SalePrice = 0m;

            // sensible defaults
            CommissionRate = 0.129m; // 12.9%
            SalesTaxRate = 0.07m; // 7%
            PromoDiscountRate = 0m;
        }

        // Constructor with parameters
        public EbayItem(string title, string condition, decimal salePrice)
        {
            Title = title;
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

        // Calculation methods
        public decimal GetCommissionAmount()
        {
            return SalePrice * CommissionRate;
        }

        public decimal GetSalesTaxAmount()
        {
            return SalePrice * SalesTaxRate;
        }

        public decimal GetNetRevenue()
        {
            return SalePrice - GetCommissionAmount() - GetSalesTaxAmount();
        }

        public decimal GetPromoDiscountAmount()
        {
            return SalePrice * PromoDiscountRate;
        }

        public decimal GetRevenueAfterDiscount()
        {
            return GetNetRevenue() - GetPromoDiscountAmount();
        }
    }
}
