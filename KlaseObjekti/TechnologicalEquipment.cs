using System;
using System.Collections.Generic;
using System.Text;

namespace KlaseObjekti
{
    public class TechnologicalEquipment : Inventory
    {
        public bool Batteries { get; set; }
        public TechnologicalEquipment(string description, DateTime purchaseDate, int warrantyLength, double price, bool batteries)
            :base(description, purchaseDate, warrantyLength, price)
        {
            Batteries = batteries;
        }           


    }
}
