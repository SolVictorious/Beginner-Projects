using System;

namespace VolumeofAcylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159265;
            int radius= 5;
            int height= 7;
            double volume = pi * (radius * radius) * height;
            Console.WriteLine("The Volume of this Cylinder is {0}",volume);
            Console.Read();

        }
    }
}
