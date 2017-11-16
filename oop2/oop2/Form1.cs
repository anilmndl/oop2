using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Rectangle rectangle = new Rectangle(5, 4);

            //Console.WriteLine(rectangle.Height);

            //rectangle.Height = 10;

            //Console.WriteLine(rectangle.Height);


            //Address address = new Address("921 S 9th Ave");
            //Student aggregation = new Student("John Doe", address);
            //Console.WriteLine(aggregation.Address.ToString());

            //Student composition = new Student("Jane Doe");
            //Console.WriteLine(composition.Address.ToString());

            Car ford150 = new Car("Ford 150");
            Console.WriteLine(ford150.Speed);

            ford150.Accelerate();

            Console.WriteLine(ford150.Speed);

            Car modelS = new Car("Tesla Model S");

            carListBox.Items.Add(ford150);
            carListBox.Items.Add(modelS);

        }

        private void carListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car selectedCar = (Car)carListBox.SelectedItem;
            Console.WriteLine(selectedCar.Speed);
        }
    }
}
