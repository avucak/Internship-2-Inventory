using System;
using System.Collections.Generic;
using System.Text;

namespace KlaseObjekti
{
    public class Vehicle :Inventory
    {
        public DateTime RegistrationExpiration { get; set; }
        public int Mileage { get; set; }
        public VehicleManufacturer VehicleManufacturer { get; set; }
        public Vehicle( string description, DateTime purchaseDate, int warrantyLength, double price, VehicleManufacturer vehicleManufacturer, DateTime registrationExpiration, int mileage)
           : base( description, purchaseDate, warrantyLength, price)
        {
            RegistrationExpiration = registrationExpiration;
            Mileage = mileage;
            VehicleManufacturer=vehicleManufacturer;
        }

    }
    public enum VehicleManufacturer
    {
        Toyota = 1,
        Ford = 2,
        Volkswagen = 3,
        Honda = 4,
        Hyundai = 5,
        Mercedes = 6,
        Suzuki = 7
    }
}
