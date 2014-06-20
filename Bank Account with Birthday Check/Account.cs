using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignent2Practice
{
    class Account
    {
        // declare variables        
        public int accountNumber;
        public string customerName;
        public decimal accountBalance;
        public string dateOfBirth;

        // default constructor creates default account
        public Account() 
        {
            this.accountNumber = 00000;
            this.customerName = "Unassigned"; 
            this.accountBalance = 0.00m;
            this.dateOfBirth = "Unassigned";
            
        }

        // create constructor
        public Account(int accountNumber, string customerName, decimal accountBalance, string dateOfBirth) 
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.accountBalance = accountBalance;
            this.dateOfBirth = dateOfBirth;
        }

        // method to print all entries
        public void PrintAllEntries(List<Account> sampleList)
        {
            foreach (var item in sampleList)
            {
                Console.WriteLine("\nName: " + item.customerName + "\nAcount Number: " + item.accountNumber + 
                    "\nAccountBalance  " + item.accountBalance + "\nDate of Birth: " + item.dateOfBirth +"\n");
            }
        }

        // Getters and setters for parameters of constructor
        public string GetName()
        {
            return customerName;
        }

        public void SetName(string name)
        {
            customerName = name;
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public void SetAccountNumber(int number)
        {
            accountNumber = number;
        }

        public decimal GetAccountBalance()
        {
            return accountBalance;
        }

        public void SetAccountBalance(decimal balance)
        {
            accountBalance = balance;
        }

        public string GetDateOfBirth()
        {
            return dateOfBirth;
        }

        public void SetDateOfBirth(string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
    } // end class Account
}
