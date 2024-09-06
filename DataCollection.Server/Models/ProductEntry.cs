using System;

namespace DataCollection.Server.Models
{
    public class ProductEntry
    {
        public string Name { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public string ProductModel { get; set; }
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

