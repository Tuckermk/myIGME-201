using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        ///new restriction is that inputs for imagStart and imagReal are doubles
        [STAThread]
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Input a lower bound of the image, default is -.6");
            double imagReal = double.Parse(Console.ReadLine());
            Console.WriteLine("Input an upper bound of the image, defualt is 1.2");
            double imagStart = double.Parse(Console.ReadLine());
            if(imagStart < imagReal) {
                Console.WriteLine("Bounds out of limit try again");
                goto start; }

            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            for (imagCoord = imagStart; imagCoord >= -imagStart; imagCoord -= (imagStart/24))
            {
                for (realCoord = imagReal; realCoord <= ((1.77/(-.6))*imagReal); realCoord += (-imagReal/20))
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
