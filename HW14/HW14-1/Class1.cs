namespace HW14_1
{


    public abstract class Q1
    {
        private string myString;
                
        public virtual string String
        {
            get { return myString; }
            set { myString = value; }
        }
    }




    public interface IGenericInterface
    {
        void printSomething();
    }

    public class GenericClass1 : IGenericInterface
    {
        void IGenericInterface.printSomething()
        {
            Console.WriteLine("Generic statement");
        }
    }
    public class GenericClass2 : IGenericInterface
    {
        void IGenericInterface.printSomething()
        {
            Console.WriteLine("This isnt actually using generics");
        }
    }
}