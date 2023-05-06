using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1and2
{
    internal class MyStack
    {

        List<int> theList;
   
        public void Push(int n)
        {
            this.theList.Insert(0, n);
        }
        public int Pop()
        {
            this.theList.Remove(theList.First());
            return theList.First();
        }
        public int Peek()
        {
            return this.theList.First();
        }


        
    }
    internal class MyQueue
    {
        
        List<int> theList;
        public void Enqueue(int n)
        {
            this.theList.Add(n);
        }
        public int Dequeue()
        {
            theList.Remove(theList.First());
            return theList.First();
        }
        public int Peek()
        {
            return theList.First();
        }

        static void Main(string[] args)
        {
           
        }
    }
}
