using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("This vehicle goes NREEEE!!");
        }

        public virtual bool HasTrunk()
        {
            return true;
        }
    }
}
