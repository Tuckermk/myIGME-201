
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            double i = 0; //syntax error add a semicolon, logic error as well needs to be able to use decimals

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i)

            // declare string to hold all numbers
           
            string allNumbers = null; //Logic error should be outside loop

            for (i = 1; i <= 10; ++i) //Logic Error add = to i <= 10
            {
                /*
                // declare string to hold all numbers
                string allNumbers = null;
                */

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = "); //Syntax for i-1  add parenthese

                // output the calculation based on the numbers
                Console.WriteLine((i / (i - 1)));
                
                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1; Logic error doesnt need to be here, already increments due to the for loop
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers); syntax error add a plus between string and variable
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
