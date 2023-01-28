using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 4 values 1 at a time: ");
            double var1 = Convert.ToDouble(Console.ReadLine());
            double var2 = Convert.ToDouble(Console.ReadLine());
            double var3 = Convert.ToDouble(Console.ReadLine());
            double var4 = Convert.ToDouble(Console.ReadLine());
            double total = var1 * var2 * var3 * var4;
            Console.WriteLine(total);

        }
    }
}
