namespace LorenzoWatkins_EbaySalesApp_Project
{
    public class EbaySales
    {
        public const string ELECTRONICS = "Electronics";
        public const string CLOTHING = "Clothing";
        public const string COLLECTIBLES = "Collectibles";
        public decimal ElectronicsFee { get; set; }
        public decimal ClothingFee { get; set; }
        public decimal CollectiblesFee { get; set; }

        public string CustomerName { get; set; }
        public string Category { get; set; }
        public decimal SaleAmount { get; set; }
        public decimal EbayFee { get; private set; }
        public decimal AmountSellerGets { get; private set; }
        public decimal EbayFeeRate { get; set; }

        public EbaySales()
        {
            CustomerName = string.Empty;
            Category = string.Empty;
            SaleAmount = 0m;
            EbayFee = 0m;
            AmountSellerGets = 0m;
            EbayFeeRate = 0.129m;
            ElectronicsFee = 0.12m;
            ClothingFee = 0.10m;
            CollectiblesFee = 0.08m;
        }

        public EbaySales(string customerName, string category, decimal saleAmount)
        {
            CustomerName = customerName;
            Category = category;
            SaleAmount = saleAmount;
            EbayFee = 0m;
            AmountSellerGets = 0m;
            EbayFeeRate = 0.129m;
            ElectronicsFee = 0.12m;
            ClothingFee = 0.10m;
            CollectiblesFee = 0.08m;
            Calculate();
        }

        public void SetFeeRates(decimal electronicsFee, decimal clothingFee, decimal collectiblesFee)
        {
            ElectronicsFee = electronicsFee;
            ClothingFee = clothingFee;
            CollectiblesFee = collectiblesFee;
        }

        public void SetFeeRate()
        {
            switch (Category)
            {
                case ELECTRONICS:
                    EbayFeeRate = ElectronicsFee;
                    break;
                case CLOTHING:
                    EbayFeeRate = ClothingFee;
                    break;
                case COLLECTIBLES:
                    EbayFeeRate = CollectiblesFee;
                    break;
                default:
                    EbayFeeRate = 0m;
                    break;
            }
        }

        public void Calculate()
        {
            EbayFee = SaleAmount * EbayFeeRate;
            AmountSellerGets = SaleAmount - EbayFee;
        }

        public override string ToString()
        {
            return "Customer: " + CustomerName + "\nCategory: " + Category + "\nSale Amount: " + SaleAmount.ToString("C") + "\neBay Fee: " + EbayFee.ToString("C") + "\nSeller Gets: " + AmountSellerGets.ToString("C");
        }
    }
}
