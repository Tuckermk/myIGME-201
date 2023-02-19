using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_13
{
    internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }
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
