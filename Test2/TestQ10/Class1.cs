using System;

namespace TestQ9
{
    public abstract class Gym : Bouldering, Rockclimbing
    {
        public string gymPhoneNumber;
        public string gymName;
        public string skillRange;

        public abstract void Ascend();
        public abstract void Climb();
        public abstract void Descend();
        public abstract void Enter();
        public abstract void Harness();
        public abstract void Jumpoff();
        public abstract void Leave();
    }
    public class Member : Gym
    {
        public int skillLevel;
        private string accountNumber;
        public virtual string AccountNumber
        {
            get{ return accountNumber; }
        }

        public override void Ascend() { Console.WriteLine("Ascending a rockclimbing wall"); }

        public override void Climb() { Console.WriteLine("Climbing a bouldering wall"); }

        public override void Descend() { Console.WriteLine("Descending a rockclimbing wall"); }

        public override void Enter() { Console.WriteLine("Entering the gym"); }

        public override void Harness() { Console.WriteLine("Harnessing yourself in"); }

        public override void Jumpoff() { Console.WriteLine("Jumping off the bouldering wall"); }


        public override void Leave() { Console.WriteLine("Leaving the gym"); }
    }

    public interface Bouldering
    {
        void Climb();
        void Jumpoff();
    }
    public interface Rockclimbing
    {
        void Harness();
        void Ascend();
        void Descend();
    }
    public class Pro : Gym
    {
        public int skillLevel;
        public int fastestTime;
        public override void Ascend() { Console.WriteLine("Quickly Ascending a rockclimbing wall"); }

        public override void Climb() { Console.WriteLine("Zooming up bouldering wall"); }

        public override void Descend() { Console.WriteLine("Controlled Falling off a rockclimbing wall"); }

        public override void Enter() { Console.WriteLine("Entering the gym"); }

        public override void Harness() { Console.WriteLine("Harnessing themselves in"); }

        public override void Jumpoff() { Console.WriteLine("flying off the bouldering wall"); }


        public override void Leave() { Console.WriteLine("Leaving the gym"); }
    }
}