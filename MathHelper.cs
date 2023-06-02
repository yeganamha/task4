using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MathHelper
    {
        public int PrintValue(int a, int b)
        { 
            return
                a + b;
        }

        public int PrintValue(bool c) 
        {
            if (c = true) ;
            return 1;
          
             
        }
        public void PrintValue(string str1, string str2)
        {
            Console.WriteLine( str1+str2);
        }

        public int PrintValue(int d, int p, int f)
        {
            return
                d * p * f;
        }

    }
}
