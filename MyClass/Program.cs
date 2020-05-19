using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("HP", "Ash", 3.5, 1, 12);
            laptop.Name = "Victor";
            var Mesage = laptop.Name + " has a " + laptop.Color + " Color " + laptop.Brand + " Laptop with a speed of " + laptop.Speed + "GHZ, " + laptop.Ram
                + "GB RAM and a Hard disk of " + laptop.DiskSize + " tarabyte.";
            Console.WriteLine(Mesage);

            Console.ReadLine();
        }
    }
}
