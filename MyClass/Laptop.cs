using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Laptop:Owner
    {
        public string Brand;
        public string Color;
        public double Speed;
        public int DiskSize;
        public int Ram;

        public Laptop(string aBrand, string aColor, double aSpeed, int aDiskSize, int aRam)
        {
            Brand = aBrand;
            Color = aColor;
            Speed = aSpeed;
            DiskSize = aDiskSize;
            Ram = aRam;


        }

    }
}
