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

     
        public int Product()
        {
            var sum = 1000;
            var a = 1;
            var product = 0;
            for (a = 1; a <= sum / 3; a++)
            {
                var b = 0;
                for (b = a + 1; b <= sum / 2; b++)
                {
                    var c = sum - a - b;
                    if (c > 0 && (a * a + b * b == c * c))

                        product = a * b * c;

                }
            }
            return product;
        } 
    }

}

