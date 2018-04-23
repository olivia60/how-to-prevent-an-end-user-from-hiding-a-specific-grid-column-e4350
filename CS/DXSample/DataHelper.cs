using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace DXSample
{
    public static class DataHelper
    {
        public static ObservableCollection<Customer> GetData()
        {
            Random rand = new Random();
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
            for (int i = 0; i < 25; i++)
            {
                
                customers.Add(
                    new Customer(
                        String.Format("FirstName{0}", rand.Next(1, 6)),
                        String.Format("LastName{0}", rand.Next(1,6)),
                        String.Format("City{0}", rand.Next(1,99)),
                        String.Format("Country{0}", rand.Next(1,4))
                    )
                );
            }
            return customers;
        }
    }

    public class Customer
    {
        public Customer(string _firstName, string _lastName, string _city, string _country)
        {
            FirstName = _firstName;
            LastName = _lastName;
            City = _city;
            Country = _country;
        }

        public Customer()
        {
            FirstName = "";
            LastName = "";
            City = "";
            Country = "";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
