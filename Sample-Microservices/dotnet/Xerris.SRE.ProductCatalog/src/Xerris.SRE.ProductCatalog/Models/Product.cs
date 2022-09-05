namespace Xerris.SRE.ProductCatalog.Models
{
    public class Product
    {
        public Guid Sku { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; }
        public string Manufacturer { get; set; }
    }
}