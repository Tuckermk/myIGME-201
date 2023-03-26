namespace TestQ9
{
    public abstract class Gym
    {
        public string gymPhoneNumber;
        public string gymName;
        public string skillRange;
        public abstract void Enter();
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
        public override void Enter() { }
        public override void Leave() { }
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
    public class Wall : Bouldering, Rockclimbing
    {
        public int skillLevel;
        void Bouldering.Climb() { }
        void Bouldering.Jumpoff() { }
        void Rockclimbing.Harness() { }
        void Rockclimbing.Ascend() { }
        void Rockclimbing.Descend() { }
    }
}