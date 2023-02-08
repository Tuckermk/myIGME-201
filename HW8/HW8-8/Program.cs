using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_8
{
    /* Class : Program
    Author : Tucker Knapman
    Purpose : Switch no to yes
    Restricitions: None */
    static internal class Program
    {
        /* Method: Main
         * Purpose: Run the solution to the question
            Restrictions: None */
        static void Main(string[] args)
        {

            string aString = "She said, No, I have nothing in my purse!";
            
            string[] aArray = aString.Split();

            for(int i = 0; i < aArray.Length; i++)
            {
                if (aArray[i].CompareTo("no") == 0 )
                {
                    aArray[i] = "yes";
                }
                else if(aArray[i].CompareTo("no,") == 0)
                {
                    aArray[i] = "yes";
                }
                if (aArray[i].CompareTo("No") == 0)
                {
                    aArray[i] = "Yes";
                }
                else if(aArray[i].CompareTo("No,") == 0){
                    aArray[i] = "Yes,";
                }
                Console.Write(aArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
