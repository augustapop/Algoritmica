using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica
{
   public class Pb7
    {
        //What is the 10 001st prime number?
       public static bool getPrime(int i)
       {
           for (int k = 2; k <= Math.Sqrt(i); k++)
           {
               if (i % k == 0)
               {
                   return false;
               }
           }
               return true;                  
       }

       public int Number()
       {
           int number = 3;
           int answer = 0;
           int count = 1;

           while (count < 1001)
           {
               if (getPrime(number))
               {
                   count++;
                   answer = number;
               }
               number++;
           }
           return answer;
       }

    }
}
