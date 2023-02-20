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
            double[,,] zFunc = new double[41, 21, 3];
            double dX, dY, dZ;
            int nX, nY;
            nX = 0;
            roundingMath deliExample;
            deliExample = new roundingMath(RoundingFunction);
            for (dX = 0; dX <= 4; dX += .1)
            {
                dX = deliExample(dX, 1);
                nY = 0;
                for(dY = -1; dY <= 1; dY += .1)
                {
                    dY = deliExample(dY, 1);
                    dZ = (4*dY*dY*dY)+(2*dX*dX)-(8*dX)+7;
                    dZ = deliExample(dZ, 3);

                    zFunc[nX, nY, 0] = dX;
                    zFunc[nX,nY,1] = dY;
                    zFunc[nX,nY,2] = dZ;
                    ++nY;
                }
                ++nX;
            }
            
        }
        /* Method: RoundingFunction
         * Purpose: Literally just do the Math.Round() command with given inputs
            Restrictions: valid input
        */
        static double RoundingFunction(double input, int decimalCount)
        {
            return Math.Round(input, decimalCount);
        }
        
        
    }
}
