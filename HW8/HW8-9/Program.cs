using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_9
{
    static internal class Program
    {

        static void Main(string[] args)
        {
            string aString = "She said, No, I have nothing in my purse!";

            string[] aArray = aString.Split();

            for(int i = 0; i < aArray.Length; i++)
            {
                aArray[i] = "\"" + aArray[i] + "\" ";
                Console.Write(aArray[i]);
            }
            Console.WriteLine();
        }
    }
}
