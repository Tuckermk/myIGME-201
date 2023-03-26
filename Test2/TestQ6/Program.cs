using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestQ4;

namespace TestQ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tardis aDoctor = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();
            
            UsePhone(aDoctor);
            UsePhone(phoneBooth);

        }
        static void UsePhone(object obj)
        {
            if (obj is Tardis)
            {
                Tardis t = (Tardis)obj;
                t.MakeCall();
                t.TimeTravel();
            }
            if (obj is PhoneBooth)
            {
                PhoneBooth pB = (PhoneBooth)obj;
                pB.MakeCall();
                pB.OpenDoor();
            }
        }
    }
}
