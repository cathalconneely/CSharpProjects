using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Motorcycle : Vehicle // subclass, inherits from vehicle.
    {

        // Motorcycle constructor declares and initializes wheels and doors of Motorcycle instances
        public Motorcycle()
        {
            this.wheels = 2;
            this.doors = 0;
        }

        // setSeats method used to set number of seats on new motorcycle object.
        // "new" keyword is used to allow method to be called independently of vehicle setSeats method
        public new void setSeats(int numSeats)
        {
            Console.WriteLine("Setting number of motorcycle seats to: " + numSeats);
            seats = numSeats;
        }

        // "new" keyword allows method to be called independently on instances of motorcycle classes
        public new virtual void displayVehicleAttributes()
        {
            Console.WriteLine("Number of Doors: " + getDoors() + "\nNumber of Seats: " + getSeats() + "\nNumber of Wheels: " + getWheels() + "\n");
        }
    } // end class
}
