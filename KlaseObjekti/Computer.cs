using System;
using System.Collections.Generic;
using System.Text;

namespace KlaseObjekti
{
    public class Computer: TechnologicalEquipment
    {
        public OperatingSystem OS { get; set; }
        public bool Laptop { get; set; }
        public ComputerManufacturer ComputerManufacturer { get; set; }
        public Computer( string description, DateTime purchaseDate, int warrantyLength, double price, ComputerManufacturer computerManufacturer, bool batteries, OperatingSystem os, bool laptop)
            : base(description, purchaseDate, warrantyLength, price, batteries)
        {
            OS = os;
            Laptop = laptop;
            ComputerManufacturer = computerManufacturer;
        }
    }
    public enum ComputerManufacturer
    {
        Dell=1,
        HP=2,
        Lenovo=3,
        Acer=4,
        Asus=5,
        Apple=6
    }
    public enum OperatingSystem
    {
        WindowsXP = 1,
        Linux = 2,
        Windows8 = 3,
        macOSX = 4
    }
}
