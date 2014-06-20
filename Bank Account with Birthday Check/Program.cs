using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignent2Practice
{

    class Program
    {
        static void Main(string[] args)
        {

            DateTime today = DateTime.Today; // DateTime object today has the current date

            Console.WriteLine("Please enter your date of birth in the following format 'yyyy-mm-dd': ");

            String myString = Console.ReadLine(); // Read user input

            DateTime myDateTime = new DateTime(); // Declare and create new DateTime object to store user input.

            // Parse user date of birth input from string and store in myDateTime
            myDateTime = DateTime.ParseExact(myString, "yyyy-MM-dd", null);

            // Get age by subtracting date of birth year from current year.
            int age = today.Year - myDateTime.Year;
            if (myDateTime > today.AddYears(-age))
            {
                age--;
            }

            // if date of birth is greater than current date, write error message.
            if (myDateTime > today)
            {
                Console.WriteLine("Error, incorrect date of birth entered!");
            }

            // else write age of user
            else
            {
                Console.WriteLine("Age: " + age);

            }

            // if date of birth's day and month equal today's date and month, and the date of birth's year is less than
            // or equal to today's year, write happy birthday.
            if (myDateTime.Day == today.Day && myDateTime.Month == today.Month && myDateTime.Year <= today.Year)
            {
                Console.WriteLine("Happy Birthday!");
            }

            Console.ReadKey();
    
            decimal minBalance = 0.00m; // variable minBalance declared and initialized

            // create Account objects
            Account myAccount1 = new Account(12345, "John Johnson", 150.00m, "1975-02-18"); 
            Account myAccount2 = new Account(12346, "Mark Morrisson", 200.00m, "1988-01-21");
            Account myAccount3 = new Account(); // create default account using default constructor

            // create List collection to store Account objects.
            List <Account> myAccountList = new List<Account>();

            // add account objects to myAccountList
            myAccountList.Add(myAccount1);
            myAccountList.Add(myAccount2);
            myAccountList.Add(myAccount3);

            // Display each account stored in the list.
            Account A = new Account();
            A.PrintAllEntries(myAccountList);// call PrintAllEntries method to display List.

            Console.ReadKey();

            // call modifyMinBalance method on minBalance to change value of minBalance by passing value
            // by reference.
            modifyMinBalance(ref minBalance);

            // pass minBalance by reference to object myAccount4, and pass date of birth value entered by user as date of birth parameter.
            Account myAccount4 = new Account(12348, "Frank Duffy", minBalance, myString);

            // add object myAccount4 to list myAccountList
            myAccountList.Add(myAccount4);

            // modify account details on the default account myAccount3 using setters
            myAccount3.SetName("Kevin Connell");
            myAccount3.SetAccountNumber(12347);

            // Delete account details for myAccount2
            myAccountList.Remove(myAccount2);

            // Display new list of accounts having modified myAccount3, deleted myAccount2, and added myAccount4      
            A.PrintAllEntries(myAccountList); // call PrintAllEntries method to display List.
            Console.ReadLine();
        }


        // method to modify minBlanace by passing value by reference
        static void modifyMinBalance(ref decimal value)
        {
            value = 100.00m;
        }
    
    } // end class
}

     
