using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAM5635_MIT.Models
{
    public class Vehicle
    {
        public string VehicleClass { get; set; }
        public string VehicleModel { get; set; }
        public string TransmissionType { get; set; }
        public string FuelConsumption { get; set; }

        public static Vehicle[] GetVehicle()
        {
            Vehicle economy = new Vehicle
            {
                VehicleClass = "Economy",
                VehicleModel = "Mitsubishi Mirage",
                TransmissionType = "Automatic",
                FuelConsumption = "30MPG"
            };
            Vehicle compact = new Vehicle
            {
                VehicleClass = "Compact",
                VehicleModel = "Nissan Versa",
                TransmissionType = "Automatic",
                FuelConsumption = "30MPG"
            };
            Vehicle intermediate = new Vehicle
            {
                VehicleClass = "Intermediate",
                VehicleModel = "Hyundai Elantra",
                TransmissionType = "Automatic",
                FuelConsumption = "28MPG"
            };
            Vehicle standard = new Vehicle
            {
                VehicleClass = "Standard",
                VehicleModel = "Kia Soul",
                TransmissionType = "Automatic",
                FuelConsumption = "27MPG"
            };
            Vehicle fullSize = new Vehicle
            {
                VehicleClass = "Full Size",
                VehicleModel = "Toyota Camry",
                TransmissionType = "Automatic",
                FuelConsumption = "26MPG"
            };
            Vehicle compactSUV = new Vehicle
            {
                VehicleClass = "Compact SUV",
                VehicleModel = "Nissan Rogue",
                TransmissionType = "Automatic",
                FuelConsumption = "24MPG"
            };
            Vehicle intermediateSUV = new Vehicle
            {
                VehicleClass = "Intermediate SUV",
                VehicleModel = "Toyota RAV4",
                TransmissionType = "Automatic",
                FuelConsumption = "24MPG"
            };
            Vehicle premium = new Vehicle
            {
                VehicleClass = "Premium",
                VehicleModel = "Nissan Maxima",
                TransmissionType = "Automatic",
                FuelConsumption = "28MPG"
            };
            Vehicle luxury = new Vehicle
            {
                VehicleClass = "Luxury",
                VehicleModel = "Cadillac XTS",
                TransmissionType = "Automatic",
                FuelConsumption = "21MPG"
            };
            Vehicle convertible = new Vehicle
            {
                VehicleClass = "Convertible",
                VehicleModel = "Ford Mustang",
                TransmissionType = "Automatic",
                FuelConsumption = "20MPG"
            };
            return new Vehicle[] { economy, compact, intermediate, standard, fullSize, compactSUV, intermediateSUV, premium, luxury, convertible, null };
        }
    }
}