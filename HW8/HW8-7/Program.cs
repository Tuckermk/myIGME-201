using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a thing to be reversed");
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            
            Console.WriteLine(inputArray);
        }
    }
}
