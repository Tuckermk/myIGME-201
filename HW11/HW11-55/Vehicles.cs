
namespace Vehicles
{
    /* Class : Vehicle
    Author : Tucker Knapman
    Purpose : Top Abstract class for Train and Car abstract classes 
    Restricitions: None */
    public abstract class Vehicle
    {
        public virtual void LoadPassenger() { }
    }
    /* Class : Car
    Author : Tucker Knapman
    Purpose : Abstract class for Compact, SUV, and Pickup 
    Restricitions: None */
    public abstract class Car : Vehicle { }
    /* Interface : IPassengerCarrier
    Author : Tucker Knapman
    Purpose : Top Interface for Passenger vehicles
    Restricitions: None */
    public interface IPassengerCarrier
    {
        void LoadPassenger();
    }
    /* Interface : IHeavyLoadCarrier
    Author : Tucker Knapman
    Purpose : Top Interface for Freight carrying stuff
    Restricitions: None */
    public interface IHeavyLoadCarrier { }
    /* Class : Train
    Author : Tucker Knapman
    Purpose : Abstract class for PassengerTrain, FreightTrain, and _424DoubleBogey
    Restricitions: None */
    public abstract class Train : Vehicle { }
    /* Class : Compact
    Author : Tucker Knapman
    Purpose : Class for Compact Cars references Car & IPassengerCarrier
    Restricitions: None */
    public class Compact : Car, IPassengerCarrier { }
    /* Class : SUV
    Author : Tucker Knapman
    Purpose : Class for SUV references Car & IPassengerCarrier
    Restricitions: None */
    public class SUV : Car, IPassengerCarrier { }
    /* Class : Pickup
    Author : Tucker Knapman
    Purpose : Class for Pickups references Car, IHeavyLoadCarrier, & IPassengerCarrier 
    Restricitions: None */
    public class Pickup : Car, IHeavyLoadCarrier, IPassengerCarrier { }

    /* Class : Train
    Author : Tucker Knapman
    Purpose : Class for Passenger Trains references Train & IPassengerCarrier
    Restricitions: None */
    public class PassengerTrain : Train, IPassengerCarrier { }

    /* Class : FreightTrain
    Author : Tucker Knapman
    Purpose : Class for frieght trains references Train & IHeavyLoadCarrier
    Restricitions: None */
    public class FreightTrain : Train, IHeavyLoadCarrier { }
    /* Class : _424DoubleBogey
    Author : Tucker Knapman
    Purpose : Class for specifically 424 Double Bogey trains I guess references Train & IHeavyLoadCarrier
    Restricitions: None */
    public class _424DoubleBogey : Train, IHeavyLoadCarrier { }

}
