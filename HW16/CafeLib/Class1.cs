namespace CafeLib
{
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public string brand;
        public Customer customer;

        public virtual void AddSugar(byte amount) { }
        public abstract void Steam();
        public HotDrink() { }
        public HotDrink(string brand) { }
    }
    public interface IMood
    {
        
        public string Mood
        {
            get { return "Mood"; }
        }
    }

    public interface ITakeOrder
    {
        public void TakeOrder() { }
    }

    public class Waiter: IMood
    {
        private string mood;
        public string name;
        public string Mood
        {
            get { return mood; }
        }
        public void ServeCustomer(HotDrink cup) { }
    }
    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;
        
    }
    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;
        public override void Steam() { }
        public void TakeOrder() { }
        public CupOfCoffee()
        {

        }
        public CupOfCoffee(string brand) : base(brand)
        {
            
        }

    }
    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;
        public override void Steam() { }
        public void TakeOrder() { }
        public CupOfTea(bool customerIsWealthy)
        {

        }

    }
    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public int numCups;
        public bool marshmellos;
        private string source;

        public string Source { 
        set {source = value;}
        }
        public override void Steam() { }
        public override void AddSugar(byte amount)
        {

        }
        public void TakeOrder() { }


        public CupOfCocoa this[bool marshmellos]
        {
            get {
                CupOfCocoa cup;
                try
                {
                    cup = (CupOfCocoa)cup[false];
                }
                catch
                {
                    cup = null;
                }
                    return cup; 
            }
        }
        public CupOfCocoa(bool marshmellos) : base("Expensive Organic Brand")
        {

        }
    }

}