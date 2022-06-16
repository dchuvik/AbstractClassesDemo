using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("This vehicle goes VREEEEEEM!!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This vehicle goes GraaGraaGraa!!");
        }

        public bool HasSideCart { get; set; }
    }
}
