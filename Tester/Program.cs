using System.Timers;
using System;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Tester
{
    public sealed class Circus
    {
        public string name;
        public string name2 = "hi";
    }


    static class Program
    {
        static void Main()
        {
            Circus myCircus = new Circus();
            Console.WriteLine( myCircus.name2);
        }
    }

}




