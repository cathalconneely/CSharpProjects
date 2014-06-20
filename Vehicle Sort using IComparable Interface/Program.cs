using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instances of motorcycle and car to enter into list
            MotorCycle m1 = new MotorCycle(1500);
            Car c1 = new Car(2500);
            MotorCycle m2 = new MotorCycle(500);
            MotorCycle m3 = new MotorCycle(2500);
            Car c2 = new Car(25000);
            Car c3 = new Car(4500);

            // create list of type Vehicle
            List<Vehicle> myVehicles = new List<Vehicle>();

            // add instances to myVehicles List
            myVehicles.Add(m1);
            myVehicles.Add(c1);
            myVehicles.Add(m2);
            myVehicles.Add(m3);
            myVehicles.Add(c2);
            myVehicles.Add(c3);

            // create dummy instance of vehicle to enable calling of call PrintEntries method
            Vehicle v1 = new Vehicle(0);

            Console.WriteLine("\nVehicle Input List: \n");

            v1.PrintEntries(myVehicles); // Call PrintEntries method and print list contents
            Console.ReadLine();
            

            // Sort myVehicles List. Sort method Uses IComparable.CompareTo()
            myVehicles.Sort();

            Console.WriteLine("Sorted Vehicle Output List: \n");

            // create dummy instance of vehicle to enable calling of PrintEntries method
            Vehicle v2 = new Vehicle(0);

            v2.PrintEntries(myVehicles); // Call PrintEntries method and print list contents

            Console.ReadLine();


        }
    }
}
