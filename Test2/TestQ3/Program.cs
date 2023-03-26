using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQ3
{
    /* Class : Program
    Author : Tucker Knapman
    Purpose : do 4y^3+2x^2-8w+7 and put it in a sorted list
    Restricitions: None */
    internal class Program
    {
        /* Method: Main
         * Purpose: do 4y^3+2x^2-8w+7 and put it in a sorted list
            Restrictions: None */
        static void Main(string[] args)
        {
            //(double, double, double) zcalc = (x,y,w);
            SortedList<(double, double, double), double> calc = new SortedList<(double, double, double), double>();

            for (double x = 0; x <= 4; x += .1)
            {
            for (double y = -1; y <= 1; y += .1)
                {
                    for (double w = -2; w <= 0; w += .2)
                    {
                        Math.Round(x, 1);
                        Math.Round(y, 1);
                        Math.Round(w, 1);
                        double z = 4*y*y*y +2*x*x -8*w +7;
                  
                        Math.Round(z, 3);
                        calc[(w, x, y)] = z;
                        Console.WriteLine(calc[(w,x,y)]);
                    }
                }
            }
            
        }
    }
}
