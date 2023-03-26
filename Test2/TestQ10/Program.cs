using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestQ9;

namespace TestQ10
{
    /* Class: Program
     * Creator: Tucker Knapman
     * Purpose: Show Polymorphism
     * Restrictions: none */
    internal class Program
    {
                
        static void Main()
        {
            Pro pro = new Pro();
            Member member = new Member();
            myMethod(pro);
            myMethod(member);
            
        }
        static void myMethod(object obj)
        {
            if (obj is Pro)
            {
                Pro myPro = (Pro)obj;
                myPro.skillLevel = 15;
                myPro.Enter();
                myPro.Ascend();
                myPro.Climb();
                myPro.Jumpoff();
                myPro.Leave();
            }

            if (obj is Member)
            {
                Member myMember = (Member)obj;
                myMember.Climb();
                myMember.Jumpoff();
                string s = myMember.AccountNumber;
                Console.WriteLine(s);
            }
        }
    }
}
