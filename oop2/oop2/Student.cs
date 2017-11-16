using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Student
    {
        // name
        private string Name { get; set; }

        // classLevel
        private string ClassLevel;

        // phoneNumber
        private int PhoneNumber;

        // address
        //private string _address;
        public Address Address { get; set; }

        // age
        private int age;

        public Student(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public Student(string name)
        {
            Name = name;
            Address = new Address("123 Test Drive");
        }

    }
}
