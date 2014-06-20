 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class VehicleTester
    {
        public static void Main()
        {
            Vehicle V = new Vehicle(); // Create instance of base class Vehicle

            //  demonstrate that V has default Vehicle attribute values.
            Console.WriteLine("Output V, an instance of default vehicle.....");
            V.displayVehicleAttributes();  // Display attributes of V, an instance of base class vehicle. 
            Console.ReadLine();

            // Create C, a car object that inherits from the vehicle class
            // C inherits all attributes from the base class but also has an added boolean parameter to set the
            // car objects transmission type. In this case, true = automatic. Parameter can also be false meaning != automatic.
            Console.WriteLine("Output C, a Car object that directly inherits the \nsuperclasses attributes along the added transmission attribute.....");
            Vehicle C = new Car(true);

            // Display attributes of car object C, method from vehicle class is overrridden by the one in the car class.
            C.displayVehicleAttributes();
            Console.ReadLine();

            Console.WriteLine("Output C having changed the number of seats it contains.....");
            C.setSeats(6); // Change number of seats in C to demonstrate use of setter through inheritance from superclass.
            C.displayVehicleAttributes(); // Display new  attributes for C
            Console.ReadLine();

            Console.WriteLine("Output M, an instance of a Motorcycle.....");
            Motorcycle M = new Motorcycle(); // Create M, a motorcycle object.

            // Set number of seats for motorcycle object M and show that "new" keyword in motorcycle class works.
            M.setSeats(1);
            M.displayVehicleAttributes(); // Display attributes of motorcycle object M
            Console.ReadLine();

            Console.WriteLine("Output Convertible, an instance of a car.......");
            Car Convertible = new Car(false); // Demonstrate setting automatic parameter to false.
            Convertible.setSeats(2); // Show "new" keyword in car setSeats method works.
            Convertible.displayVehicleAttributes(); // Display Convertible attributes and show overriding method works

            Console.ReadLine();
            

        } // end main method
    } // end class
}
