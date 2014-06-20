using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Car: Vehicle // subclass, inherits from Vehicle
    {
        // car class has boolean attribute automatic.
        public bool automatic;

        // car constructor inherits attributes, wheels, doors and seats directly from base class,
        // but has added boolean parameter "autmoatic" to constructor.
        public Car(bool automatic):base()
        {
            this.automatic = automatic;
        }
        
        // Set number of seats in car
        // keyword "new" enables method to be called separately to base class setSeats method.
        public new void setSeats(int numSeats)
        {
            Console.WriteLine("Setting number of Car seats to: " + numSeats); 
            seats = numSeats;
        }

        // Returns automatic which is a boolean attribute of  the Car class and a parameter of the car constructor
        // which is set by the user when a car instance is created.
        public bool getTransmission()
        {
            return automatic;
        }

        // override displayVehicleAttributes() method to include display value for transmission type (automatic: true/false)
        public override void displayVehicleAttributes()
        {
            Console.WriteLine("Number of Doors: " + getDoors() + "\nNumber of Seats: " + getSeats() + "\nNumber of Wheels: " + getWheels() + "\nAutomatic: " + getTransmission() + "\n");
        }
    } // end class
}
