using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica
{
   public  class Pb4
    {
       public string LargestPalindrom()
       {
           string palindrom = "";
           int p = 0;
           for (int i = 100; i < 1000; i++)
           {
               for (int j = 100; j < 1000; j++)
               {

                   string total = (i * j).ToString();
                   if(total==new string(total.Reverse().ToArray()))
                   {
                       if ((i * j) > p)
                       {
                           p = i * j;
                           palindrom = p.ToString();
                       }
                   }
               }

           } return palindrom;
       
       }
    }
}
