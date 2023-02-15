using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    public delegate string ReadLine();
    

internal class Program
    {
        
        static void Main(string[] args)
        {
           ReadLine deli = new ReadLine(ReadLineImpersonator);
        }
        static string ReadLineImpersonator()
        {
            return Console.ReadLine();
        }
    }
}
