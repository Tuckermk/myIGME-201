using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Knapman_HelloWorld
{
    
    /* Class : Program
    Author : Tucker Knapman
    Purpose : Console printout 
    Restricitions: None */
     
    static internal class Program
    {
        /* Method: Main
         * Purpose: Test some variables and strings then follow up with 
                    calling the math function 
            Restrictions: None */
        static void Main(string[] args)
        {
            Int32 int32variable = 0;

            Console.WriteLine("Input first name:\t");
            string first = Console.ReadLine();
            Console.WriteLine("Input last name:\t");
            string last = Console.ReadLine();
            
            Console.Write(" Your name is " + first + " " + last);
            Console.WriteLine("\nTucker Knapman \t");
            Math();
        }
        /* Method: Math
         * Purpose: Add & Multiply numbers as well as get inputed numbers
            Restrictions: None */
        static void Math()
        {
            int parentInt = 0;
            {
                parentInt = 1;
                Console.WriteLine(parentInt);
            } //These prints end up both printing 1
            Console.WriteLine(parentInt);


            Console.WriteLine("Input any number:\t");
            string sInput = Console.ReadLine();
            int nInput = 0;

            
            bool bValid = false;
            while (!bValid)
            {
                bValid = int.TryParse(sInput, out nInput);

                // 3 different methods of converting string to number
                try
                {
                    nInput = Convert.ToInt32(sInput);
                }
                catch
                {

                    Console.WriteLine("Actually put in a number");
                }
                try
                {
                    nInput = int.Parse(sInput);
                }
                catch
                {
                    Console.WriteLine("Actually put in a number");
                }
            }

            int x = 2;
            int y = nInput;
            x++; //x is 3 now
            Console.WriteLine(x);
            Console.WriteLine(x + x); // doing x+x and (x+x) does end up being the same thing
            Console.WriteLine("x * 2 = " + (x * 2));

            //Exponential test
            int xMultiplier = x;
            while (x < y)
            {
                x = x * xMultiplier;
                Console.WriteLine(x);
            }

        }
    }
}
