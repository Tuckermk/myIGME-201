using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_12
{
    /* Class : Program
    Author : Tucker Knapman
    Purpose : Raise my salary
    Restricitions: None */
    internal class Program
    {
        /* Method: Main
         * Purpose: Read if its me and raise only my salary
            Restrictions: None*/
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.WriteLine("Input name");
            sName = Console.ReadLine();
            GiveRaise(sName, ref dSalary);
        }
        static bool GiveRaise(string name, ref double salary)
        {
            if (name.ToLower() != "tucker")
            {
                return false;
            }

            salary += 19999.99;
            Console.WriteLine("Congrats on payraise");
            return true;
        }
    }
}
