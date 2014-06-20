using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindOddNumbers
{
    class Program
    {

        static void OddNumbers(int a)
        {
            if (a <= 10000) // determines highest possible number
            {

                if (a % 2 == 0) // if a is an even number
                {                    
                    a = a + 1; // add 1 to make it odd.
                }
                
              Console.WriteLine(a); // print odd number to console.
             
              a += 2; // add 2 to a to proceed to next odd number.
                   
              OddNumbers(a); // recursive call of OddNumbers method on a.

            }
            
        } // end OddNumbers method.
           
   
        
        static void Main()
        {
            int Number = 0; // initialize base number.

            Console.WriteLine("Odd Numbers: "); // Print string.
            OddNumbers(Number); // call OddNumbers method on Number.

            Console.ReadLine(); // Allow display of output in console.
        } // End main method
    } // End class
} // End namespace

           
        
    

