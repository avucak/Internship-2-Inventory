using System;
using System.Collections.Generic;

namespace KlaseObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moguće opcije: \n1.Dodavanje \n2.Brisanje \n3.Ispis preko unesenog serijskog broja" +
                "\n4.Ispis računala kojima garancija ističe nekoj godini"+
                "\n5.Ispis koliko komada tehnološke opreme ima baterije \n6.Ispis svih mobitela određene marke"+
                "\n7.Ispis računala s određenim operacijskim sustavom"+
                "\n8.Ispis imena i brojeva vlasnika mobitela kojima garancija ističe u određenoj godini"+
                "\n9.Ispis vozila koijma registracija ističe u sljedećih mjesec dana"+
                "\n10.Ispis cijene sve opreme, pri kupnji, trenutno te razliku");

            List<Computer> computers=new List<Computer>();
            List<MobilePhone> mobilePhones=new List<MobilePhone>();
            List<Vehicle> vehicles=new List<Vehicle>();
            
            Initialize(computers, mobilePhones, vehicles);
           
            string choice;
            do
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Za unos kompjutera unesite 1, za unos mobitela 2, a za unos vozila 3");
                        var choice2 = Console.ReadLine();
                        if (choice2 == "1")
                        {
                            Console.WriteLine("Unos kompjutera\nUnesite opis:");
                            var description = Console.ReadLine();
                            Console.WriteLine("Unesite godinu kada je kupljen:");
                            var year = int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite mjesec kada je kupljen:");
                            var month= int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite dan kada je kupljen");
                            var day = int.Parse(Console.ReadLine());
                            Console.WriteLine("Broj mjeseci garancije:");
                            var warranty = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cijena:");
                            var price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Koji je proizvođač, od ponuđenih");
                            foreach (var name in Enum.GetNames(typeof(ComputerManufacturer)))
                            {
                                Console.Write(name + " ");
                            }
                            Console.Write("\n");
                            
                            var flag = false;
                            ComputerManufacturer computerManufacturer=ComputerManufacturer.Acer;
                            while (!flag)
                            {   var input = Console.ReadLine();
                                foreach (var name in Enum.GetValues(typeof(ComputerManufacturer)))
                                {
                                    if (name.ToString().ToUpper() == input.ToUpper())
                                    {
                                        flag = true;
                                        computerManufacturer = (ComputerManufacturer)name;
                                    }
                                }
                                if (!flag)
                                {
                                    Console.WriteLine("Niste upisali jedan od ponuđenih, ponovite: ");
                                }
                            }
                            flag = false;
                            var batteries = false;
                            while (!flag)
                            {
                                Console.WriteLine("Ima li baterije(true/false):");
                                var input = Console.ReadLine();
                                if (input.ToLower() == "true")
                                {
                                    batteries = true;
                                    flag = true;
                                }
                                else if (input.ToLower() == "false")
                                    flag = true;
                            }
                            Console.WriteLine("Koji je os, od ponuđenih");
                            foreach (var name in Enum.GetNames(typeof(OperatingSystem)))
                            {
                                Console.Write(name + " ");
                            }
                            Console.Write("\n");
                            flag = false;
                            OperatingSystem operatingSystem=OperatingSystem.Linux;
                            while (!flag)
                            {
                                var input = Console.ReadLine();
                                foreach (var name in Enum.GetValues(typeof(OperatingSystem)))
                                {
                                    if (name.ToString().ToUpper() == input.ToUpper())
                                    {
                                        flag = true;
                                        operatingSystem = (OperatingSystem)name;
                                    }
                                }
                                if (!flag)
                                {
                                    Console.WriteLine("Niste upisali jedan od ponuđenih, ponovite: ");
                                }
                            }
                            flag = false;
                            var laptop = false;
                            while (!flag)
                            {
                                Console.WriteLine("Je li laptop(true/false):");
                                var input = Console.ReadLine();
                                if (input.ToLower() == "true")
                                {
                                    laptop = true;
                                    flag = true;
                                }
                                else if (input.ToLower() == "false")
                                    flag = true;
                            }

                            computers.Add(new Computer(description,new DateTime(year,month,day), warranty, price, computerManufacturer, batteries, operatingSystem, laptop));
                            
                        }
                        else if (choice2 == "2")
                        {
                            Console.WriteLine("Unos mobitela\nUnesite opis:");
                            var description = Console.ReadLine();
                            Console.WriteLine("Unesite godinu kada je kupljen:");
                            var year = int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite mjesec kada je kupljen:");
                            var month = int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite dan kada je kupljen");
                            var day = int.Parse(Console.ReadLine());
                            Console.WriteLine("Broj mjeseci garancije:");
                            var warranty = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cijena:");
                            var price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Koji je proizvođač, od ponuđenih");
                            foreach (var pm in Enum.GetNames(typeof(PhoneManufacturer)))
                            {
                                Console.Write(pm + " ");
                            }
                            Console.Write("\n");

                            var flag = false;
                            PhoneManufacturer phoneManufacturer = PhoneManufacturer.Apple;
                            while (!flag)
                            {
                                var input = Console.ReadLine();
                                foreach (var pm in Enum.GetValues(typeof(PhoneManufacturer)))
                                {
                                    if (pm.ToString().ToUpper() == input.ToUpper())
                                    {
                                        flag = true;
                                        phoneManufacturer = (PhoneManufacturer)pm;
                                    }
                                }
                                if (!flag)
                                {
                                    Console.WriteLine("Niste upisali jedan od ponuđenih, ponovite: ");
                                }
                            }
                            flag = false;
                            var batteries = false;
                            while (!flag)
                            {
                                Console.WriteLine("Ima li baterije(true/false):");
                                var input = Console.ReadLine();
                                if (input.ToLower() == "true")
                                {
                                    batteries = true;
                                    flag = true;
                                }
                                else if (input.ToLower() == "false")
                                    flag = true;
                            }
                            Console.WriteLine("Broj mobitela:");
                            var phoneNumber = Console.ReadLine();
                            Console.WriteLine("Ime vlasnika:");
                            var name = Console.ReadLine();
                            Console.WriteLine("Prezime vlasnika:");
                            var surname = Console.ReadLine();


                            mobilePhones.Add(new MobilePhone(description, new DateTime(year, month, day), warranty, price, phoneManufacturer, batteries,phoneNumber,name,surname));

                        }
                        else if (choice2 == "3")
                        {
                            Console.WriteLine("Unos vozila\nUnesite opis:");
                            var description = Console.ReadLine();
                            Console.WriteLine("Unesite godinu kada je kupljen:");
                            var year = int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite mjesec kada je kupljen:");
                            var month = int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite dan kada je kupljen");
                            var day = int.Parse(Console.ReadLine());
                            Console.WriteLine("Broj mjeseci garancije:");
                            var warranty = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cijena:");
                            var price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Koji je proizvođač, od ponuđenih");
                            foreach (var name in Enum.GetNames(typeof(VehicleManufacturer)))
                            {
                                Console.Write(name + " ");
                            }
                            Console.Write("\n");

                            var flag = false;
                            VehicleManufacturer vehicleManufacturer = VehicleManufacturer.Ford;
                            while (!flag)
                            {
                                var input = Console.ReadLine();
                                foreach (var name in Enum.GetValues(typeof(VehicleManufacturer)))
                                {
                                    if (name.ToString().ToUpper() == input.ToUpper())
                                    {
                                        flag = true;
                                        vehicleManufacturer = (VehicleManufacturer)name;
                                    }
                                }
                                if (!flag)
                                {
                                    Console.WriteLine("Niste upisali jedan od ponuđenih, ponovite: ");
                                }
                            }
                            Console.WriteLine("Unesite godinu kada ističe registracija:");
                            var yearE = int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite mjesec:");
                            var monthE = int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite dan");
                            var dayE = int.Parse(Console.ReadLine());
                            Console.WriteLine("Kilometraza na vozilu: ");
                            var mileage = int.Parse(Console.ReadLine());
                            vehicles.Add(new Vehicle(description, new DateTime(year, month, day), warranty, price, vehicleManufacturer, new DateTime(yearE, monthE, dayE), mileage));
                        }
                        else
                            Console.WriteLine("Niste odabrali neku od postojećih opcija, unos prekinut");
                        break;
                    case "2":
                        Console.WriteLine("Za brisanje kompjutera unesite 1, mobitela 2, vozila 3");
                        choice2 = Console.ReadLine();
                        if (choice2 == "1")
                        {
                            var serialN = "";
                            foreach (var c in computers)
                            {
                                Console.WriteLine(c.SerialNumber.ToString() + " " + c.ComputerManufacturer + " " + c.OS); 
                            }
                            Console.WriteLine("Unesite prvih 5 znakova serijskog broja racunala koje zelite obrisati: ");
                            serialN = Console.ReadLine();
                            if (EraseComputer(serialN, computers))
                                Console.WriteLine("Obrisan");
                            else
                                Console.WriteLine("Brisanje nije uspjelo");

                        }
                        else if (choice2 == "2")
                        {
                            var serialN = "";
                            foreach (var m in mobilePhones)
                            {
                                Console.WriteLine(m.SerialNumber.ToString() + " " + m.PhoneManufacturer.ToString() + " " + m.PhoneNumber);
                            }
                            Console.WriteLine("Unesite prvih 5 znakova serijskog broja mobitela koje zelite obrisati: ");
                            serialN = Console.ReadLine();
                            if (ErasePhone(serialN, mobilePhones))
                                Console.WriteLine("Obrisan");
                            else
                                Console.WriteLine("Brisanje nije uspjelo");
                        }
                        else if (choice2 == "3")
                        {
                            var serialN = "";
                            foreach (var v in vehicles)
                            {
                                Console.WriteLine(v.SerialNumber.ToString() + " " + v.VehicleManufacturer);
                            }
                            Console.WriteLine("Unesite prvih 5 znakova serijskog broja vozila koje zelite obrisati: ");
                            serialN = Console.ReadLine();
                            if (EraseVehicle(serialN, vehicles))
                                Console.WriteLine("Obrisan");
                            else
                                Console.WriteLine("Brisanje nije uspjelo");
                        }
                        else
                            Console.WriteLine("Niste odabrali neku od postojećih opcija, brisanje prekinuto");
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":

                        break;
                    case "9":

                        break;
                    case "10":

                        break;
                    default:
                        break;
                }
            }
            while (choice != "10");

        }
        static void Initialize(List<Computer>computers,List<MobilePhone>mobilePhones,List<Vehicle>vehicles)
        {
            computers.Add(new Computer("oštećen", new DateTime(2005, 11, 23), 36, 5500, ComputerManufacturer.Acer, true, OperatingSystem.Linux, true));
            computers.Add(new Computer("vrlo skup",new DateTime(2013,1,3),50,15500,ComputerManufacturer.Apple,true,OperatingSystem.macOSX,true));
            computers.Add(new Computer("vrh",new DateTime(2016,8,22),24,3900,ComputerManufacturer.HP,true,OperatingSystem.WindowsXP,true));
            computers.Add(new Computer("ovo je loš opis,ali i ostali su",new DateTime(2018,5,13),36,6200,ComputerManufacturer.Dell,true,OperatingSystem.Windows8,true));
            computers.Add(new Computer("crvene boje",new DateTime(2017,12,25),24,4889,ComputerManufacturer.Asus,true,OperatingSystem.Windows8,true));

            
            mobilePhones.Add(new MobilePhone("Ericsson", new DateTime(2015, 11, 3), 12, 2500, PhoneManufacturer.Sony, true, "0955585999", "Maja", "T"));
            mobilePhones.Add(new MobilePhone("iznenađujuće jeftin",new DateTime(2017,6,27),18,5,PhoneManufacturer.Apple,true,"0987777777","Toma","Peric"));
            mobilePhones.Add(new MobilePhone("izdržljiv",new DateTime(2012,2,22),6,3000,PhoneManufacturer.Huawei,true,"0918989898","Tina","Ivanova"));
            mobilePhones.Add(new MobilePhone("A8",new DateTime(2018,10,5),24,4600,PhoneManufacturer.Samsung,true,"0995095099","Alan","Po"));
            mobilePhones.Add(new MobilePhone("neslomljiv", new DateTime(2011, 5, 29), 100, 5500, PhoneManufacturer.Nokia, true, "0912212212", "Ivo", "Ivic"));



            vehicles.Add(new Vehicle("u dobrom stanju", new DateTime(2014, 12, 3), 24, 80000, VehicleManufacturer.Ford, new DateTime(2020, 11, 23), 89032));
            vehicles.Add(new Vehicle("raspada se",new DateTime(2005,9,23),60,120000,VehicleManufacturer.Suzuki,new DateTime(2019,2,4),1000));
            vehicles.Add(new Vehicle("star",new DateTime(2000,8,1),72,110000,VehicleManufacturer.Hyundai,new DateTime(2018,12,23),6700));
            vehicles.Add(new Vehicle("super",new DateTime(2007,7,14),60,140000,VehicleManufacturer.Honda,new DateTime(2019,1,20),20000));
            vehicles.Add(new Vehicle("nov",new DateTime(2018,4,19),48,200000,VehicleManufacturer.Mercedes,new DateTime(2021,4,12),15685));

            
        }

        static bool EraseComputer(string serialN, List<Computer> computers)
        {
            var erased = false;
            Computer toErase=null;
            foreach (var c in computers)
            {
                if (c.SerialNumber.ToString().Substring(0, 5) == serialN)
                    toErase = c;
            }
            if (toErase != null)
            {
                computers.Remove(toErase);
                erased = true;
            }
            return erased;
        }
        static bool ErasePhone(string serialN, List<MobilePhone> mobilePhones)
        {
            var erased = false;
            MobilePhone toErase = null;
            foreach (var m in mobilePhones)
            {
                if (m.SerialNumber.ToString().Substring(0, 5) == serialN)
                    toErase = m;
            }
            if (toErase != null)
            {
                mobilePhones.Remove(toErase);
                erased = true;
            }
            return erased;
        }
        static bool EraseVehicle(string serialN, List<Vehicle> vehicles)
        {
            var erased = false;
            Vehicle toErase = null;
            foreach (var v in vehicles)
            {
                if (v.SerialNumber.ToString().Substring(0, 5) == serialN)
                    toErase = v;
            }
            if (toErase != null)
            {
                vehicles.Remove(toErase);
                erased = true;
            }
            return erased;
        }


    }
}
