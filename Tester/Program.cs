using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] ascendingNumbers = new int[5];
            for (int i = 0; i < ascendingNumbers.Length; i++)
            {
                ascendingNumbers[i] = i + 1;
            }



            double[] percipitation;
            percipitation = new double[4];
            percipitation[0] = .45;
            percipitation[1] = 2.78;
            percipitation[2] = .04;
            percipitation[3] = 1.22;



        }
        enum colors : ushort
        {
            red,
            orange,
            yellow,
            green,
            blue,
            purple,
            black,
            white
        }
        static float test()
    {

        byte x = 0;
        return x;
    }



    } 
}

