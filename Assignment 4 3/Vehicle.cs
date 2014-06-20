using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{

    class Vehicle: IComparable<Vehicle>// superclass Vehicle implements generic interface Icomparable<>
    {
        // declare vehicle attributes      
        public int value;

        // create vehicle constructor
        public Vehicle(int value)
        {
            this.value = value;
        }

        // implement IComparable interface using CompareTo method
        public int CompareTo(Vehicle other)
        {
            if (this.GetType().Name == other.GetType().Name) // use getType().Name method to compare Classes of instances                                                            
            {
                return other.value.CompareTo(this.value); // sort values from high to low
            }
            return this.GetType().Name.CompareTo(other.GetType().Name); // default to type sort high putting cars first

        }

        // ToString method can be overridden to return value and type 
        // use getType().Name method to return Class Name of instance
        public override string ToString()
        {
            return this.GetType().Name + " $" + this.value;
        }

        // PrintEntries method takes List parameter of Vehicle type and Writes to console
        public void PrintEntries(List<Vehicle> sampleList)
        {

            foreach (var element in sampleList)
            {
                Console.WriteLine(element);
            }
        }

    } // end class
}


  
