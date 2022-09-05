namespace Xerris.SRE.PricingEngine.Models
{
    public class Price
    {
        public Guid Sku { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal WholesalePrice { get; set; }
    }
}