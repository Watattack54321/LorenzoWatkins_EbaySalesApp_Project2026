using System.Globalization;

namespace LorenzoWatkins_EbaySalesApp_Project
{
    public class EbaySales
    {
        public string CustomerName { get; set; }
        public decimal SaleAmount { get; set; }
        public decimal EbayFee { get; private set; }
        public decimal AmountSellerGets { get; private set; }
        public decimal EbayFeeRate { get; set; }

        public EbaySales()
        {
            CustomerName = string.Empty;
            SaleAmount = 0m;
            EbayFee = 0m;
            AmountSellerGets = 0m;
            EbayFeeRate = 0.129m;
        }

        public EbaySales(string customerName, decimal saleAmount)
        {
            CustomerName = customerName;
            SaleAmount = saleAmount;
            EbayFeeRate = 0.129m;
            Calculate();
        }

        public void Calculate()
        {
            EbayFee = SaleAmount * EbayFeeRate;
            AmountSellerGets = SaleAmount - EbayFee;
        }

        public override string ToString()
        {
            return $"Customer: {CustomerName} | Sale Amount: {SaleAmount.ToString("C", CultureInfo.CurrentCulture)} | eBay Fee: {EbayFee.ToString("C", CultureInfo.CurrentCulture)} | Seller Gets: {AmountSellerGets.ToString("C", CultureInfo.CurrentCulture)}";
        }
    }
}
