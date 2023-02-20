using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_14
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //Compile time, missing a ;
            //int nY
            int nY;
            int nAnswer;
            //Compile time missing ""
            //Console.WriteLine(This program calculates x ^ y.);
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Compile error as the readline isnt given a variable to store the info
                //Console.ReadLine(); 
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));
            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
                Console.WriteLine(sNumber);
                //Runtime error, inputs what we are trying to get for y as X, also never ends due to missing !
            } //while (int.TryParse(sNumber, out nX));
            while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);
            //Logical error, doesnt actually output values
            //Console.WriteLine("{nX}^{nY} = {nAnswer}");
            Console.WriteLine(nX +"^" + nY +" = " + nAnswer);
        }

        //Compile time, due to this not being static, prevented it from being actively called
        //int Power(int nBase, int nExponent)
       static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //Logical error, makes every input result in 0 by multiplying by 0
                //returnVal = 0;
                returnVal = 1;
                
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //Runtime error, the exponent only ever increasing instead of decreasing
                //nextVal = Power(nBase, nExponent + 1);
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }
            //Compile time as it doesnt actually return anything
            //returnVal;
            return returnVal;

        }
    }

}
