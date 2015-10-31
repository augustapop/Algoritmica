using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica
{
   public class Pb9
    {
         //There exists exactly one Pythagorean triplet
         //for which a + b + c = 1000.
        //Find the product abc

       public bool Found()
       {
           int a = 0, b = 0, c = 0;
           int s = 1000;
           bool found = false;
           for (a = 1; a < s / 3; a++)
           {
               for (b = a; b < s / 2; b++)
               {
                   c = s - a - b;

                   if (a * a + b * b == c * c)
                   {
                       found = true;
                       break;
                   }
               }
               if (found)
               {
                   break;
               }
           }
           return true;
       }
    }
}
