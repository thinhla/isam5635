using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ISAM5635_MIT.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Production_Year { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }

        public Car()
        {
        }


        public Car(int car_id, string brand, string model, int production_year, string color, string status, string category)
        {
            Id = car_id;
            Brand = brand;
            Model = model;
            Production_Year = production_year;
            Color = color;
            Status = status;
            Category = category;
        }

        public static Car[] GetCar()
        {
            Car economy = new Car(0001, "Mitsubishi", "Mirage", 2017, "White", "Available", "Economy");
            Car compact = new Car(0002, "Nissan", "Versa", 2017, "Black", "Available", "Compact");
            Car intermediate = new Car(0003, "Hyundai", "Elantra", 2018, "Blue", "Available", "Intermediate");
            Car standard = new Car(0004, "Kia", "Soul", 2018, "White", "Available", "Standard");
            Car fullsize = new Car(0005, "Toyota", "Camry", 2017, "Red", "Available", "Fullsize");
            Car compactSuv = new Car(0006, "Nissan", "Rogue", 2017, "Yellow", "Available", "Compact SUV");
            Car intermediateSuv = new Car(0007, "Toyota", "RAV4", 2018, "Gray", "Available", "Intermediate SUV");
            Car premium = new Car(0008, "Nissan", "Maxima", 2017, "Black", "Available", "Premium");
            Car luxury = new Car(0009, "Cadillac", "XTS", 2017, "Brown", "Available", "Luxury");
            Car convertible = new Car(0010, "Ford", "Mustang", 2018, "Green", "Available", "Convertible");

            return new Car[] { economy, compact, intermediate, standard, fullsize, compactSuv, intermediateSuv, premium, luxury, convertible};
        }
    }

    public class InventoryDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}
