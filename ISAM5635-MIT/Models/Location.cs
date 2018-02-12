using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAM5635_MIT.Models
{
    public class Location
    {
        public string Location_Name { get; set; }
        //ClearLake/Katy /Galleria/Spring/Woodlands 

        public Location(string location_name)
        {
            Location_Name = location_name;
        }

        public static Location[] GetLocation()
        {
            Location houston = new Location("Houston");
            Location dallas = new Location("Dallas");
            Location austin = new Location("Austin");
            Location atlanta = new Location("Atlanta");
            Location chicago = new Location("Chicago");
            Location seattle = new Location("Seattle");
            Location miami = new Location("Miami");
            Location orlando = new Location("Orlando");
            Location tampa = new Location("Tampa");
            Location boston = new Location("Boston");

            return new Location[] {boston, null};
        }
    }
}
