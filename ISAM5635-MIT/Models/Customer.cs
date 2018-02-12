

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAM5635_MIT.Models
{
    public class Customer
    {
        public string Username { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public string License { get; set; }

        public Customer(string username, string firstname, string lastname, DateTime date_of_birth, string license)
        {
            Username = username;
            FirstName = firstname;
            LastName = lastname;
            Date_of_Birth = date_of_birth;
            License = license;
        }

        public static Customer[] GetCustomer()
        {
            Customer john = new Customer("john", "John", "Doe", DateTime.Parse("01/01/1990"), "Texas");
            Customer jack = new Customer("jack", "Jack", "Doe", DateTime.Parse("01/01/1980"), "Louisiana");
            Customer david = new Customer("david", "David", "Doe", DateTime.Parse("01/01/1985"), "California");
            Customer peter = new Customer("peter", "Peter", "Doe", DateTime.Parse("01/01/1988"), "Florida");
            Customer michael = new Customer("michael", "Michael", "Doe", DateTime.Parse("01/01/1987"), "Georgia");
            return new Customer[] { john, jack, david, peter, michael };
        }
    }
}
