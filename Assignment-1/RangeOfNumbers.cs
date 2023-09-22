using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class RangeOfNumbers
    {
        public RangeOfNumbers()
        {
            for (int num = 2000; num <= 3200; num++) 
            {
                if(num % 7 == 0 && num%5 !=0)
                {
                    Console.Write(num + ",");
                }
            }
        }
    }
}
