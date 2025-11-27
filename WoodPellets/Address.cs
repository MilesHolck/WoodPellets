using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPellets
{
    public class Address
    {

        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; } 

        public Address(string street, string number, string city, string zipCode)
        {
            Street = street;
            Number = number;
            City = city;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{Street}, no. {Number}, {ZipCode}, {City}.";
           
        }
    }
}
