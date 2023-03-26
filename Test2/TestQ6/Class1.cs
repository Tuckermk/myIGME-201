namespace TestQ4
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber { get; set; }
        public abstract void Connect();
        public abstract void Disconnect();
    }
    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }
    public class RotaryPhone : Phone, PhoneInterface
    {
        public override void Connect() { }
        public override void Disconnect() { }
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }
    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public override void Connect() { }
        public override void Disconnect() { }
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public virtual byte WhichDrWho
        { 
            get { return whichDrWho; }
        }
        public virtual string FemaleSideKick
        {
            get { return femaleSideKick; }
        }
        public void TimeTravel() { }
        public static bool operator== (Tardis Dr1, Tardis Dr2) {

            return Dr1.whichDrWho == Dr2.whichDrWho;

        }
        public static bool operator!= (Tardis Dr1,Tardis Dr2) 
        {
            return Dr1.whichDrWho != Dr2.whichDrWho;
        }
        public static bool operator< (Tardis Dr1, Tardis Dr2)
        {
            if (Dr2.whichDrWho == 10) return true;
            return Dr1.whichDrWho < Dr2.whichDrWho;
        }
        public static bool operator >(Tardis Dr1, Tardis Dr2)
        {
            if (Dr1.whichDrWho == 10) return true;
            return Dr1.whichDrWho > Dr2.whichDrWho;
        }
        public static bool operator <=(Tardis Dr1, Tardis Dr2)
        {
            if (Dr2.whichDrWho == 10) return true;
            return Dr1.whichDrWho <= Dr2.whichDrWho;
        }
        public static bool operator >=(Tardis Dr1, Tardis Dr2)
        {
            if (Dr1.whichDrWho == 10) return true;
            return Dr1.whichDrWho >= Dr2.whichDrWho;
        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor() { }
        public void CloseDoor() { }
    }

}