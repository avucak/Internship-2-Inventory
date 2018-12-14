using System;
using System.Collections.Generic;
using System.Text;

namespace KlaseObjekti
{
    public class Inventory
    {
        public Guid SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int WarrantyLength { get; set; }
        public double Price { get; set; }
        //public string Brand { get; set; }

        public Inventory(string description, DateTime purchaseDate, int warrantyLength, double price)
        {
            SerialNumber = Guid.NewGuid();
            Description = description;
            PurchaseDate = purchaseDate;
            WarrantyLength = warrantyLength;
            Price = price;
            //Brand = brand;
        }
    }
}
