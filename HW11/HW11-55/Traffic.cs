using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;


namespace Traffic
{
    /* Class : Traffic
    Author : Tucker Knapman
    Purpose : Add a passenger
    Restricitions: Valid  input*/
    internal class Traffic
    {
        void AddPassenger(Vehicles.IPassengerCarrier i)
        {
            i.LoadPassenger();
            Console.WriteLine(i.ToString());
        }
    }
}
