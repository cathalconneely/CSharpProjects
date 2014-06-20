using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Vehicle // superclass
    {
        // declare vehicle attributes
        public int doors;
        public int seats;
        public int wheels;

        // create vehicle constructor and declare vehicle attribute values
        public Vehicle()
        {
            wheels = 4;
            doors = 4;
            seats = 4;
        }

        // sets number of seats
        public void setSeats(int numSeats)
        {
            Console.WriteLine("Setting number of vehicle Seats to: " + numSeats);
            seats = numSeats;
        }

        // returns number of seats
        public int getSeats()
        {
            return seats;
        }

        // returns number of wheels
        public int getWheels()
        {
            return wheels;
        }

        // returns number of doors
        public int getDoors()
        {
            return doors;
        }

        // virtual keyword used to allow overriding in subclassses.
        // Method displays vehicle attributes.
        public virtual void displayVehicleAttributes()
        {
            Console.WriteLine("Number of Doors: " + getDoors() + "\nNumber of Seats: " + getSeats() + "\nNumber of Wheels: " + getWheels() + "\n");
        }



    } // end class
}
