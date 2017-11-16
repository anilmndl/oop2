using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        //or
        //private string _name;
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        public Car(string name)
        {
            Name = name;
            Speed = 0;
        }

        // accelerate
        public void Accelerate()
        {
            Speed += 5;
        }

        override
        public string ToString()
        {
            return Name;
        }


        


    }
}
