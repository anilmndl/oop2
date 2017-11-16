using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Address
    {
        // street address
        private string _streetAddress;

        // city
        private string _city;

        // zip code
        private int _zipCode;    // assuming zip codes do not start with zeros

        public Address(string streetAddress)
        {
            _streetAddress = streetAddress;
        }

        override
        public string ToString()
        {
            return _streetAddress;
        }

    }
}
