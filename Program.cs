// Homework No. 3. Exercise No. 2
//File Name: Homework3_Part2.cs
// @Nasi Bode
// Date: 11 Dec 2023
// Problem Statement:write a prgram that determines the change to be dispensed from a vending
// machine. An item in the machine can cost between 25 cents and 1 dollar, in 5 cent increments,
// and the machine accepts only a single dollar bill to pay for the item. 
//
// Overall Plan:
// 1. Import  objects
// 2. create a greetings,stating what the program will do
// 3. prompt user to enter price of item
// 4. Use Convert.ToInt32 to read input from user
// 5. find the amount needed to return / convert to quarters and dimes
// 6. Use the % remainder to find the accurate amount of quarters/nickels/dimes for the change
// 7. print change to the screen
 

//create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //print welcoming message to the screen
            Console.WriteLine("This program will determine the change that is");
            Console.WriteLine("to be dispensed from a vending machine.");
            Console.WriteLine("This program only dispenses in 5-cent increments");
            Console.WriteLine("Please enter the price of  the item (from 25cents to a dollar)");

            //get and assign any necessary input
            int amount, quarters, dimes, nickels, pennies, originalAmount;

            amount = Convert.ToInt32(Console.ReadLine());
            originalAmount = 100 - amount;

            Console.WriteLine("You will receive:  " + originalAmount);

            //using the % to find  the remainder
            //process thhe input and assign to variables as needed
            quarters = originalAmount / 25;
            originalAmount = originalAmount % 25;

            dimes = originalAmount / 10;
            originalAmount = originalAmount % 10;

            nickels = originalAmount / 5;
            originalAmount = originalAmount % 5;


            //print results
            Console.WriteLine(quarters + " Quarters, " + dimes + " dimes, " + nickels + " nickels");

        }
    }
}

