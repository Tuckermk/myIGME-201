using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_13
{

    /* Class : Program
    Author : Tucker Knapman
    Purpose : Raise my salary, but with a struct
    Restricitions: None */
    internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }
        /* Method: Main
         * Purpose: Raise my salary if I give it my name
            Restrictions: None*/
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            employee sEmployee = new employee();
            Console.WriteLine("Input name");
            sEmployee.sName = Console.ReadLine();         

            GiveRaise(sEmployee);
        }
        static bool GiveRaise(employee employ)
        {
            if (employ.sName.ToLower() != "tucker")
            {
                return false;
            }

            employ.dSalary += 19999.99;
            Console.WriteLine("Congrats on payraise");
            return true;
        }
    }
}
