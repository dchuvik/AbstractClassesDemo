﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle 
             *                  (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car toyota = new Car()
            {
                Year = "2000",
                Make = "Toyota",
                Model = "Corolla"
            };

            Motorcycle Suzuki = new Motorcycle()
            {
                Year = "1998",
                Make = "Suzuki",
                Model = "GSXR 600"
            };
            Vehicle subaru = new Car()
            {
                Year = "2020",
                Make = "Subaru",
                Model = "Legacy"
            };
            Vehicle hondaGrom = new Motorcycle()
            {
                Year = "2019",
                Make = "Honda",
                Model = "CBR 250",
                
            };

            vehicles.Add(toyota);
            vehicles.Add(Suzuki);
            vehicles.Add(subaru);
            vehicles.Add(hondaGrom);

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                vehicle.DriveVirtual();
                Console.WriteLine("------------------------------");
            }
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */


            // Call each of the drive methods for one car and one motorcycle

            toyota.DriveAbstract();
            toyota.DriveVirtual();
            toyota.HasTrunk();
            Suzuki.DriveAbstract();
            Suzuki.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
