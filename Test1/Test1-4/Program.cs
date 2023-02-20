using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Question4
{
    using System.IO;
    using System;
    using System.Timers;


    class Program
    {
        static Action target = new Action(Main);
        static bool bTimeOut = false;
        static Timer timeoutTimer;
        static void Main()
        {

            // string and int of # of questions
            string sQuestion = "";
            int nQuestion = 0;


            string sAnswer = "";

            // string and int for the response
            string sResponse = "";
            Int32 nResponse = 0;

            // boolean for checking valid input
            bool bValid = false;

            // play again?
            string sAgain = "";

        // label to return to if they want to play again
        start:
            bTimeOut = false;

            // initialize correct responses for each time around



            do
            {
                Console.Write("Choose your question (1-3): ");
                sQuestion = Console.ReadLine();

                try
                {
                    nQuestion = int.Parse(sQuestion);
                    bValid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number 1 to 3.");
                    bValid = false;
                }

            } while (!bValid);

            Console.WriteLine();



            // the questions
            if (nQuestion == 1)
            {
                sQuestion = "What is your favorite color";
                sAnswer = "black";
            }

            else if (nQuestion == 2)
            {
                sQuestion = "What is answer to life, the universe and everything?";
                sAnswer = "42";
            }
            else if (nQuestion == 3)
            {
                sQuestion = "What is the airspeed velocity of an unladen swallow?";
                sAnswer = "what do you mean? african or european swallow?";
            }
            else
            {
                goto start;
            }
            // display the question and prompt for the answer
            timeoutTimer = new Timer(5000);
            timeoutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

            do
            {

                //HERE IS WHERE TO START TIMER
                Console.WriteLine("You have 5 seconds to answer the following question:");
                Console.WriteLine(sQuestion);
                timeoutTimer.Start();
                bTimeOut = false;
                sResponse = Console.ReadLine();

                timeoutTimer.Stop();


            } while (!bValid);

            // if response == answer, output flashy reward and increment # correct
            // else output stark answer
            if (sResponse.ToLower() == sAnswer)
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine("Wrong! The answer is: " + sAnswer);
            }


            Console.WriteLine();

        end:

            do
            {
                // prompt if they want to play again
                Console.Write("Play again? ");

                sAgain = Console.ReadLine();

                if (sAgain.ToLower().StartsWith("y"))
                {
                    goto start;
                }
                else if (sAgain.ToLower().StartsWith("n"))
                {
                    break;
                }
            } while (true);


        }

        static void TimesUp(object sender, ElapsedEventArgs e)
        {
            
            Console.WriteLine("Your time is up! (hit enter)");


            bTimeOut = true;
            timeoutTimer.Stop();

        }
    }
}