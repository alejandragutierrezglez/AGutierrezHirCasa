using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class ClassB
    {
        private int rec = 1;
        public int test(int a, int b)
        {
            if (a == rec)
            {
                Console.WriteLine("OK" + a);
            }
            rec = rec * b;
            return rec;
        }
    }
}
