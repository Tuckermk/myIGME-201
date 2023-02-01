using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    /* Class : Program
    Author : Tucker Knapman
    Purpose : Console printout 
    Restricitions: None */
    static internal class Program
    {
        /* Method: Main
         * Purpose: Run the solutions to the questions
            Restrictions: None */
        static void Main(string[] args)
        {
            Q2();
        }


        /* Method: Q2
         * Purpose: Question 2 solution
            Restrictions: inputting ints less than 10 for var1 and 2 */
        static void Q2()
        {

        start:
            bool oper1 = false;
            bool oper2 = false;

            Console.WriteLine("Input 2 ints");
            int var1 = int.Parse(Console.ReadLine());
            int var2 = int.Parse(Console.ReadLine());


            if (var1 >= 10) { oper1 = true; }
            if (var2 >= 10) { oper2 = true; }
            if (oper1 && oper2 == true)
            {
                Console.WriteLine("Input valid ints");
                goto start;
            }

            Console.WriteLine("Var1: " + var1 + " Var2: " + var2);

        }


        /* Method: Q1
         * Purpose: Workspace for getting through Q1
            Restrictions: None */
        static void Q1()
        {
            int var1 = 0;
            int var2 = 0;
            bool oper1 = false;
            bool oper2 = false;
            if (var1 <= 10)
            {
                oper1 = true;
            }
            if (var2 <= 10)
            {
                oper2 = true;
            }
            if (oper1 != oper2) { Console.WriteLine("realize that this is basically number 2"); }
        }
        
        /* Method: Q4
         * Purpose: Question 4 workspace
            Restrictions: None */
        static void Q4()
        {
            int number = 4;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Just");
                    break;
                case 2:
                case 4:
                    Console.WriteLine("an");
                    goto default;
                    

                default:
                    Console.WriteLine("example");
                    break;
            }
        }

        /* Method: Q5
         * Purpose: Question 5 workspace
            Restrictions: None */
        static void Q5()
        {
            string favoriteFood = "spaghetti";
            switch ("spaghetti")
            {
                case ("spaghetti"):
                    Console.WriteLine("You seem to really like spaghetti");
                    break;
                case ("cake"):
                    Console.WriteLine("Wrong. Spaghetti is the best food.");
                    break;
               default:
                Console.WriteLine("You should like spaghetti.");
            }

        }
    }
}
