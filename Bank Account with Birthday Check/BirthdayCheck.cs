using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignent2Practice
{
    class BirthdayCheck
    {
           // data members
           DateTime myDateTime;
           DateTime today;
           int age;
          
           // constructor
           public BirthdayCheck(DateTime myDateTime, DateTime today){

               this.myDateTime = myDateTime;
               this.today = today;

           }
               
            // Get age by subtracting date of birth year from current year.
            public void setAge(DateTime today, DateTime myDateTime){
                
                age = today.Year - myDateTime.Year;
            }

            public void checkDOB(DateTime today, DateTime myDateTime)
            {
                if (myDateTime > today.AddYears(-age))
                {
                    age--;
                }
                
                // if date of birth's day and month equal today's date and month, and the date of birth's year is less than
                // or equal to today's year, write happy birthday.
                else if (myDateTime.Day == today.Day && myDateTime.Month == today.Month && myDateTime.Year <= today.Year)
                {
                    Console.WriteLine("Happy Birthday! Congratulations on turning " + age);
                }


                // if date of birth is greater than current date, write error message.
                else if (myDateTime > today)
                {
                    Console.WriteLine("Error, incorrect date of birth entered!");
                }

                // else write age of user
                else
                {
                    Console.WriteLine("Age: " + age);

                }               
            } // end checkDob method

    } // end class
}
