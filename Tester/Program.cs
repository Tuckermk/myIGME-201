using System.Timers;
using System;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Tester
{
    static class Program
    {
        
        public class MyClass
        {
            public int myInt;
            public MyClass(int nVal)
            {
                this.myInt += nVal;
            }
            public object Shallow()
            {
                return this.MemberwiseClone();
            }
        }
        public class MyDerivedClass : MyClass
        {
            public MyDerivedClass(int nVal) : base(nVal){
                this.myInt = (this.myInt + 2)*4;
            }
        }
        static void Main(string[] args)
        {
            MyDerivedClass myObj = new MyDerivedClass(42);

            MyClass objectA = new MyClass(22);
            MyClass objectB = (MyClass)objectA.Shallow();
        }

    }
}




