using System;

namespace ObjectoOriantedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            jobs wizard = new jobs("Wizard",8,12,7,5);
            wizard.Description();

            jobs warrior = new jobs("Warrior", 12, 5, 7, 10);
            warrior.Description();

            Console.Read();


        }
    }
}
