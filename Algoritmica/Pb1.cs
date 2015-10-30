using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1)Find the sum of all the multiples of 3 or 5 below 1000

namespace Algoritmica
{
   public  class Pb1
    {
       public int Sum()
       {
           int sum = 0;
           for (int i = 0; i < 1000; i++)
           {
               if (i % 3 == 0 || i % 5 == 0)
               {
                   sum = sum + i;
               }
           }

           return sum;

       }
    }
}
