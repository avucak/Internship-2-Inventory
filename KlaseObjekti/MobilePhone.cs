using System;
using System.Collections.Generic;
using System.Text;

namespace KlaseObjekti
{
    public class MobilePhone:TechnologicalEquipment
    {
        public string PhoneNumber { get; set; }
        public string OwnerName { get; set; }
        public string OwnerSurname { get; set; }
        public PhoneManufacturer PhoneManufacturer { get; set; }
        public MobilePhone( string description, DateTime purchaseDate, int warrantyLength, double price, PhoneManufacturer phoneManufacturer, bool batteries, string phoneNumber, string ownerName, string ownerSurname)
           : base( description, purchaseDate, warrantyLength, price, batteries)
        {
            PhoneNumber = phoneNumber;
            OwnerName = ownerName;
            OwnerSurname = ownerSurname;
            PhoneManufacturer = phoneManufacturer;
        }
    }
    public enum PhoneManufacturer
    {
        Nokia = 1,
        Apple = 2,
        Samsung = 3,
        Sony = 4,
        LG = 5,
        Huawei = 6
    }
}
