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
            Console.WriteLine("VREEEEEEM!!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("GraaGraaGraa!!");
        }

        public bool HasSideCart { get; set; }
    }
}
