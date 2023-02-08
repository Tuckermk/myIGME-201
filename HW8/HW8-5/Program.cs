using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_5
{
    /* Class : Program
    Author : Tucker Knapman
    Purpose : Make a 3D array with given function for Z
            and X and Y ranges
    Restricitions: None */
    internal class Program
    {
        /* Method: Main
         * Purpose: Run the solution to the question
            Restrictions: None*/
        static void Main(string[] args)
        {
            double[,,] superArray;
            double x;
            double y;
            double z;
            superArray = new double[31, 41, 50];
            for (x = -1; x <= 1; x += .1)
            {

                for (y = 1; y <= 4; y += .1)
                {

                    z = 3 * Math.Pow(y, 2) + (2 * x) - 1;
                    int xInt = (int)(x * 10) + 10;
                    int yInt = (int)(y * 10);
                    int zInt = (int)z;

                    superArray[xInt, yInt, zInt] = z;
                }
            }

        }
    }
}