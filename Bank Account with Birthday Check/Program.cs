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

            Console.WriteLine("Please enter your date of birth in the following format 'yyyy-mm-dd': ");

            String myString = Console.ReadLine(); // Read user input
            DateTime myDate = new DateTime();
            DateTime now = DateTime.Today; // DateTime object today has the current dat
            myDate = DateTime.ParseExact(myString, "yyyy-MM-dd", null);

            BirthdayCheck myBirthday = new BirthdayCheck(myDate, now);

            myBirthday.setAge(now, myDate);
            myBirthday.checkDOB(now, myDate);
          
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

            // call modifyMinBalance method on minBalance to demonstrate changing value of minBalance by passing value
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

     
