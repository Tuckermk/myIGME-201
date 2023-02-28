using HW12_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12_3
{
    public class MyDerivedClass : MyClass
    {
        private string MyString;
        public override string GetString
        {
            get { return MyString + "(Output from derived class)"; }
            
        }
        static public void Main()
        {
            MyClass k = new MyClass();
            Console.WriteLine($"HI{k.GetString}");
            MyDerivedClass c = new MyDerivedClass();
            Console.WriteLine($"BYE{c.GetString}");

        }

    }
}
