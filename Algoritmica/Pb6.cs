using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica
{
    //
   public  class Pb6
    {
       //Find the difference between the sum of the 
       //squares of the first one hundred natural 
       //numbers and the square of the sum.

       public int SumPb6()
       {
           int min=1;
           int max=100;
           int sumOfSq = 0;
           int temp = 0;
           int sqOfSum = 0;

           for (int i = min; i <= max; i++)
           { 
           sumOfSq+=(i*i);
           }

           for (int i = min; i < max; i++)
           {
               temp += i;
           }
           sqOfSum = temp * temp;

           return sqOfSum - sumOfSq;

       }

    }
}
