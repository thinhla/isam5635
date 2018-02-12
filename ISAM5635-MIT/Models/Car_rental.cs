
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAM5635_MIT.Models
{
    public class Car_rental
    {
        public int Rental_ID { get; set; }
        public int Car_ID { get; set; }
        public string Username { get; set; }
        public string Location_Name{ get; set; }
        public string Pickup { get; set; }
        public string Dropoff { get; set; }
        public DateTime Booking_StartDate{ get; set; }
        public DateTime Booking_EndDate { get; set; }

        public Car_rental(int rental_id, int car_id, string username, string location_name, string pickup, string dropOff, DateTime booking_startdate, DateTime booking_endtate)
        {
            Rental_ID = rental_id;
            Car_ID = car_id;
            Username = username;
            Location_Name = location_name;
            Pickup = pickup;
            Dropoff = dropOff;
            Booking_StartDate = booking_startdate;
            Booking_EndDate = booking_endtate;
        }

    }
}
