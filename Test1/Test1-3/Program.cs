using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_3
{
    /* Class: Program
     * By: Tucker Knapman
     * Purpose: Answer question 3 of test by making a delegate
     * Restriction: None
     */ 

    internal class Program
    {
        delegate double roundingMath(double n, int d);

        /* Method: Main
         * By: Tucker Knapman
         * Purpose: be example  for a delegate
         */
        static void Main(string[] args)
        {
            double testValue = 3.3;
            roundingMath deliExample;
            deliExample = new roundingMath(RoundingFunction);
        }

        static double RoundingFunction(double input, int decimalCount)
        {
            return Math.Round(input, decimalCount);
        }
        
        
    }
}
