using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica
{
   
    public class Pb2
    {
        public int Suma()
        {
            //2)By considering the terms in the Fibonacci sequence
            //whose values do not exceed four million, find the sum of
            //the even-valued terms

            int sum = 0;
            int f1 = 1, f2 = 1, temp = 0;
            while (f2 < 4000000)
            {
                if (f2 % 2 == 0)
                {
                    sum = sum + f2;
                    temp = f1 + f2;
                    f1 = f2;
                    f2 = temp;
                }
            }
            return sum;
        }
    }
}
