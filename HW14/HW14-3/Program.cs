
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW14_3
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
    internal class Program
    {

        static void Main(string[] args)
        {
            GenericClass1 myClass1 = new GenericClass1();
            GenericClass2 myClass2 = new GenericClass2();
            MyMethod(myClass1);
            MyMethod(myClass2);
        }
        public static void MyMethod(object myObject)
        {
            IGenericInterface myInterface = (IGenericInterface)myObject;
            myInterface.printSomething();
        }
    }
}
